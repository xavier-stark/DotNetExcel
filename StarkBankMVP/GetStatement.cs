using Microsoft.VisualStudio.Tools.Applications.Runtime;
using StarkBankMVP.Forms;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace StarkBankMVP
{
    public partial class GetStatement
    {
        private void Planilha7_Startup(object sender, System.EventArgs e)
        {
        }

        private void Planilha7_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region Código gerado pelo Designer VSTO

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InternalStartup()
        {
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.Startup += new System.EventHandler(this.Planilha7_Startup);
            this.Shutdown += new System.EventHandler(this.Planilha7_Shutdown);

        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            ViewStatementForm statementForm = new ViewStatementForm();
            statementForm.ShowDialog();
        }
    }
}
