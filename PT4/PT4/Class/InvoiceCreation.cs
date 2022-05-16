using Aspose.Pdf;
using System;
using System.Collections.Generic;

namespace PT4
{
    /// <summary>
    /// Classe de génération de facture
    /// </summary>
    internal class InvoiceCreation
    {
        public string num { get; set; }
        public double total { get; set; }
        public List<DerivedProduct> productList { get; set; }
        public String date { get; set; }
        public String clientName { get; set; }

        /// <summary>
        /// Méthode de création d'une facture sous forme de pdf
        /// </summary>
        public void Create()
        {
#pragma warning disable CS0472 // Le résultat de l'expression est toujours 'false', car une valeur de type 'double' n'est jamais égale à 'null' du type 'double?'
            if (productList == null || num == null || total == null || date == null || clientName == null)
#pragma warning restore CS0472 // Le résultat de l'expression est toujours 'false', car une valeur de type 'double' n'est jamais égale à 'null' du type 'double?'
                return;

            Document pdf = new Document();
            Page page = pdf.Pages.Add();

            AddParagraph(page, "Facture", 25);
            CreateSpace(page);

            //Entête de la facture
            AddParagraph(page, "Entreprise de Annie Maux", 12);
            AddParagraph(page, "adresse physique", 12);
            AddParagraph(page, "adress mail", 12);
            AddParagraph(page, "+33 00 00 00 00 00 00", 12);
            CreateSpace(page);

            //Tableau d'information
            Table contactInfo = new Table();
            InitTab(contactInfo);

            Row header = contactInfo.Rows.Add();

            // En tête de tableau
            header.Cells.Add("Facturé à:");
            header.Cells.Add("Envoyé à:");
            header.Cells.Add("Facture n°:" + num);

            //Ligne tableau
            Row row1 = contactInfo.Rows.Add();
            row1.Cells.Add(clientName);
            row1.Cells.Add(clientName);
            row1.Cells.Add(date);

            Row row2 = contactInfo.Rows.Add();
            row2.Cells.Add("adresse de création de facture");
            row2.Cells.Add("adresse d'envoie");

            page.Paragraphs.Add(contactInfo);
            CreateSpace(page);

            //Création de la table de produit
            Table tableProduct = new Table();
            InitTab(tableProduct);

            //Première ligne
            Row fRow = tableProduct.Rows.Add();

            // Ajout des colonnes
            fRow.Cells.Add("Quantité");
            fRow.Cells.Add("Nom");
            fRow.Cells.Add("Prix unitaire HT");
            fRow.Cells.Add("Montant HT");

            decimal totalHT = 0;
            decimal TVA = new Decimal(1.2);

            foreach (DerivedProduct prod in productList)
            {
                // Ajout d'une ligne
                Row row = tableProduct.Rows.Add();

                // Ajout des colonnes
                row.Cells.Add(prod.boughtQuantity.ToString());
                row.Cells.Add(prod.produit.nomProduit);

                decimal amountHT = Math.Round(Decimal.Divide(prod.produit.prixVenteClient, TVA), 2);
                totalHT += amountHT * prod.boughtQuantity;

                row.Cells.Add(amountHT.ToString());
                row.Cells.Add((amountHT * prod.boughtQuantity).ToString());
            }

            page.Paragraphs.Add(tableProduct);
            CreateSpace(page);

            AddParagraph(page, "Total HT: " + totalHT.ToString() + "€", 10);
            AddParagraph(page, "TVA 20%: " + (Decimal.Parse(total.ToString()) - totalHT).ToString() + "€", 10);
            AddParagraph(page, "Total: " + total.ToString() + "€", 10);

            //Emplacement de sauvegarde de la facture
            pdf.Save("C:/Users/Public/Downloads/Invoice_number_" + num + ".pdf");
        }

        /// <summary>
        /// Méthode permettant de sauter une ligne dans le pdf
        /// </summary>
        /// <param name="page">Page de travail pdf</param>
        private void CreateSpace(Page page)
        {
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment(" "));
        }


        /// <summary>
        /// Méthode permettant d'initialiser un tableau sur une page pdf
        /// </summary>
        /// <param name="tab">Tableau à initialiser</param>
        private void InitTab(Table tab)
        {
            tab.Border = new BorderInfo(BorderSide.All, .5f, Color.FromRgb(System.Drawing.Color.LightGray));
            tab.DefaultCellBorder = new BorderInfo(BorderSide.All, .5f, Color.FromRgb(System.Drawing.Color.LightGray));
        }

        /// <summary>
        /// Méthode permettant d'ajouter un paragraphe au pdf
        /// </summary>
        /// <param name="page">Page de travai pdf</param>
        /// <param name="text">Text souhaitant être mis dans le paragraphe</param>
        /// <param name="fontSize">Taille de la police à écrire</param>
        private void AddParagraph(Page page, string text, int fontSize)
        {
            Aspose.Pdf.Text.TextFragment textFrag = new Aspose.Pdf.Text.TextFragment(text);
            textFrag.TextState.FontSize = fontSize;
            page.Paragraphs.Add(textFrag);
        }
    }
}
