﻿namespace LightSwitchApplication
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Reflection;
	using DocumentFormat.OpenXml;
	using DocumentFormat.OpenXml.Packaging;
	using DocumentFormat.OpenXml.Wordprocessing;

	internal static class DocumentGenerator
	{
		#region Constants

		private const string TEMPLATE = "LightSwitchApplication.Template.docx";

		#endregion

		#region DocumentTags

		private const string ADDRESS_TAG = "[[" + DocDescriptor.ADDRESS + "]]";
		private const string A_NR_TAG = "[[" + DocDescriptor.A_NR + "]]";
		private const string BRUTTO_TAG = "[[" + DocDescriptor.BRUTTO + "]]";
		private const string K_NR_TAG = "[[" + DocDescriptor.K_NR + "]]";
		private const string L_AMOUNT_TAG = "[[" + DocDescriptor.L_AMOUNT + "]]";
		private const string L_DATE_TAG = "[[" + DocDescriptor.L_DATE + "]]";
		private const string L_NR_WORD = "Lieferscheinnummer:";
		private const string L_NR_TAG = "[[" + DocDescriptor.L_NR + "]]";						
		private const string MAHN_TAG = "[[" + DocDescriptor.MAHN + "]]";
		private const string NETTO_TAG = "[[" + DocDescriptor.NETTO + "]]";
		private const string R_DATE_TAG = "[[" + DocDescriptor.R_DATE + "]]";
		private const string R_NR_TAG = "[[" + DocDescriptor.R_NR + "]]";
		private const string TAX_TAG = "[[" + DocDescriptor.TAX + "]]";
		private const string TITLE_TAG = "[[" + DocDescriptor.TITLE + "]]";
		private const string V_DATE_WORD = "Versanddatum:";
		private const string V_DATE_TAG = "[[" + DocDescriptor.V_DATE + "]]";


		#endregion

		internal static byte[] ProcessDocument(DocDescriptor data, bool asPdf = false)
		{
			using (MemoryStream ms = CreateTemplate())
			{
				WordprocessingDocument doc = WordprocessingDocument.Open(ms, true);
				Body body = doc.MainDocumentPart.Document.Body;

				#region Table
				if (data.Positionen.Count > 0)
				{
					var table = body.Elements<Table>().FirstOrDefault(n => n.Any(m => m.OuterXml.Contains("MapTableNoHeading")));
					var row = table.ChildElements.OfType<TableRow>().LastOrDefault();
					var rowParas = FindElements<Paragraph>(row).ToArray();
					var first = data.Positionen.OfType<Position>().First();
					InsertTextRun(rowParas[0], "1");
					InsertTextRun(rowParas[1], first.Artikelnummer);
					InsertTextRun(rowParas[2], first.Bezeichnung);
					InsertTextRun(rowParas[3], first.Anzahl.ToString());
					InsertTextRun(rowParas[4], first.PosPreis.ToString("C"));
					InsertTextRun(rowParas[5], first.Preis.ToString("C"));

					if (data.Positionen.Count > 1)
					{
						OpenXmlElement last = row;
						for (int i = 1; i < data.Positionen.Count; i++)
						{
							var newRow = new TableRow(row.OuterXml);
							last = last.InsertAfterSelf(newRow);
							var current = data.Positionen.OfType<Position>().ElementAt(i);
							var paras = FindElements<Paragraph>(last).ToArray();
							InsertTextRun(rowParas[0], (i + 1).ToString());
							InsertTextRun(rowParas[1], first.Artikelnummer);
							InsertTextRun(rowParas[2], first.Bezeichnung);
							InsertTextRun(rowParas[3], first.Anzahl.ToString());
							InsertTextRun(rowParas[4], first.PosPreis.ToString("C"));
							InsertTextRun(rowParas[5], first.Preis.ToString("C"));
						}
					}
				}
				#endregion

				#region Replacements
				foreach (var item in FindElements<Text>(body, n => !String.IsNullOrWhiteSpace(n.Text)))
				{
					if (item.Text.Contains(ADDRESS_TAG))
					{
						if (data.Adresse == null)
						{
							item.Text = item.Text.Replace(ADDRESS_TAG, String.Empty);
						}
						else
						{
							string[] parts = data.Adresse.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
							if (parts.Length == 0)
								parts = new string[] { "" };
							item.Text = item.Text.Replace(ADDRESS_TAG, String.IsNullOrWhiteSpace(data.Adresse) ? String.Empty : parts[0]);
							OpenXmlElement last = item;
							for (int i = 1; i < parts.Length; i++)
							{
								last = last.InsertAfterSelf(new Break());
								last = last.InsertAfterSelf(new Text(parts[i]));
							}
						}
					}

					if (item.Text.Contains(A_NR_TAG))
						item.Text = item.Text.Replace(A_NR_TAG, String.IsNullOrWhiteSpace(data.Auftragsnummer) ? "" : data.Auftragsnummer);

					if (item.Text.Contains(BRUTTO_TAG))
						item.Text = item.Text.Replace(BRUTTO_TAG, String.IsNullOrWhiteSpace(data.Brutto) ? "" : data.Brutto);

					if (item.Text.Contains(R_DATE_TAG))
						item.Text = item.Text.Replace(R_DATE_TAG, String.IsNullOrWhiteSpace(data.Rechnungsdatum) ? "" : data.Rechnungsdatum);

					if (item.Text.Contains(L_DATE_TAG))
						item.Text = item.Text.Replace(L_DATE_TAG, String.IsNullOrWhiteSpace(data.Lieferdatum) ? "" : data.Lieferdatum);

					if (item.Text.Contains(L_AMOUNT_TAG))
						item.Text = item.Text.Replace(L_AMOUNT_TAG, String.IsNullOrWhiteSpace(data.Lieferkosten) ? "" : data.Lieferkosten);

					if (item.Text.Contains(L_NR_TAG))
						item.Text = item.Text.Replace(L_NR_TAG, String.IsNullOrWhiteSpace(data.Lieferscheinnummer) ? "" : data.Lieferscheinnummer);

					if (item.Text.Contains(TAX_TAG))
						item.Text = item.Text.Replace(TAX_TAG, String.IsNullOrWhiteSpace(data.Mehrwertsteuer) ? "" : data.Mehrwertsteuer);

					if (item.Text.Contains(NETTO_TAG))
						item.Text = item.Text.Replace(NETTO_TAG, String.IsNullOrWhiteSpace(data.Netto) ? "" : data.Netto);

					if (item.Text.Contains(R_NR_TAG))
						item.Text = item.Text.Replace(R_NR_TAG, String.IsNullOrWhiteSpace(data.Rechnungsnummer) ? "" : data.Rechnungsnummer);

					if (item.Text.Contains(TITLE_TAG))
						item.Text = item.Text.Replace(TITLE_TAG, String.IsNullOrWhiteSpace(data.Titel) ? "" : data.Titel);

					if (item.Text.Contains(V_DATE_TAG))
						item.Text = item.Text.Replace(V_DATE_TAG, String.IsNullOrWhiteSpace(data.Versanddatum) ? "" : data.Versanddatum);

					if (item.Text.Contains(K_NR_TAG))
						item.Text = item.Text.Replace(V_DATE_TAG, String.IsNullOrWhiteSpace(data.Kundennummer) ? "" : data.Kundennummer);

					if (item.Text.Contains(MAHN_TAG))
						item.Text = item.Text.Replace(MAHN_TAG, String.IsNullOrWhiteSpace(data.Mahnkosten) ? "" : data.Mahnkosten);

					if (item.Text.Contains(L_NR_WORD))
						if (String.IsNullOrWhiteSpace(data.Lieferscheinnummer))
							item.Text = item.Text.Replace(L_NR_WORD, "");
					
					if (item.Text.Contains(V_DATE_WORD))
						if (String.IsNullOrWhiteSpace(data.Versanddatum))
							item.Text = item.Text.Replace(V_DATE_WORD, "");
					
				}
				#endregion

				doc.Close();
#if DEBUG
				File.WriteAllBytes(@"C:\users\Richment\Desktop\test.docx", ms.ToArray());
#endif
				if (asPdf)
					return DocumentToPdf(ms.ToArray());
				else
					return ms.ToArray();
			}
		}

		internal static byte[] DocumentToPdf(byte[] docBytes)
		{
			byte[] result = null;
			using (MemoryStream ms = new MemoryStream(docBytes))
			{
				Spire.Doc.Document doc = new Spire.Doc.Document(ms);
				using (MemoryStream target = new MemoryStream())
				{
					doc.SaveToStream(target, Spire.Doc.FileFormat.PDF);
					result = target.ToArray();
				}
#if DEBUG
				File.WriteAllBytes(@"C:\users\Richment\Desktop\test.pdf", result);
#endif
				return result;
			}
		}

		#region Private methods

		private static MemoryStream CreateTemplate()
		{
			var result = new MemoryStream();
			using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(TEMPLATE))
			{
				if (resourceStream == null)
					return null;

				resourceStream.CopyTo(result);
			}
			result.Seek(0L, SeekOrigin.Begin);
			return result;
		}

		private static IEnumerable<T> FindElements<T>(OpenXmlElement root, Predicate<T> predicate = null) where T : OpenXmlElement
		{
			if (predicate == null)
			{
				foreach (var item in root.ChildElements)
				{
					if (item is T)
						yield return item as T;
					foreach (var child in FindElements<T>(item))
						yield return child;
				}
			}
			else
			{
				foreach (var item in root.ChildElements)
				{
					if (item is T)
						if (predicate(item as T))
							yield return item as T;
					foreach (var child in FindElements<T>(item))
						if (predicate(child as T))
							yield return child as T;
				}
			}
		}

		private static Text InsertTextRun(OpenXmlElement parent, string text)
		{
			OpenXmlElement last = parent;
			if (last is Paragraph)
				last = last.AppendChild(new Run());
			if (last is Run)
				return last.AppendChild(new Text(text));
			return InsertTextRun(last.AppendChild(new Paragraph()), text);
		}
		
		#endregion
	};
}