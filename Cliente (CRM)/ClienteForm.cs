using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;
using System.Globalization;
using cliente;
using System.Net.Sockets;
using System.Net.Mail;
using System.Net;


namespace Cliente__CRM_
{
   
    public partial class ClienteForm : Form,ISubject
    {
        public ClienteForm()
        {
            InitializeComponent();
            
        }

        private List<IObserver> observers;
        public int rowEscribir = 0;
        float Total = 0;
        public static ConexionTcp conexionTcp = new ConexionTcp();
        string filename;
        public string IPADDRESS;
        public int PORT;
       
        public int IdProducto;
        private void Form1_Load(object sender, EventArgs e)
        {       
            this.clienteTableAdapter1.Fill(this.factura_clienteDataSetNuevo.cliente);          
            this.productosTableAdapter.Fill(this.factura_clienteDataSet.Productos);
           this.clienteTableAdapter.Fill(this.factura_clienteDataSet.cliente);
        }

        public void DGVAux_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCantidad_P.Text = "";
            Total -= float.Parse(DGVAux.Rows[e.RowIndex].Cells[3].Value.ToString()) * float.Parse(DGVAux.Rows[DGVAux.CurrentRow.Index].Cells[2].Value.ToString());
            lblTotal.Text = Total.ToString();
            

            DGVAux.Rows.Remove(DGVAux.CurrentRow);
        }

        private void DGVTotalProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCantidad_P.Text = "";
            IdProducto = Convert.ToInt32(DGVTotalProductos.Rows[e.RowIndex].Cells[0].Value.ToString());
           
            DGVAux.Rows.Add(DGVTotalProductos[0, e.RowIndex].Value, DGVTotalProductos[1, e.RowIndex].Value, DGVTotalProductos[2, e.RowIndex].Value, DGVTotalProductos[3, e.RowIndex].Value);
          //recorre el DGVAux en busca de repetidos 
             for(int i=0; i<DGVAux.Rows.Count; i++)
            {
            DGVAux.FirstDisplayedScrollingRowIndex = DGVAux.Rows[i].Index;
            DGVAux.Refresh();
            DGVAux.CurrentCell = DGVAux.Rows[i].Cells[0];
            DGVAux.Rows[i].Selected = true;
                //Elimina todos los que esten repetidos si el actual seleccionado se encuentra en algun otro 
                if (e.ColumnIndex == 0 && DGVAux.CurrentCell.Value != null|| e.ColumnIndex == 1 && DGVAux.CurrentCell.Value != null|| e.ColumnIndex == 2 && DGVAux.CurrentCell.Value != null|| e.ColumnIndex == 3 && DGVAux.CurrentCell.Value != null)
                {
                    foreach (DataGridViewRow row in this.DGVAux.Rows)
                    {
                        if (row.Index == this.DGVAux.CurrentCell.RowIndex)
                        {
                            continue;
                        }
                        if (this.DGVAux.CurrentCell.Value == null)
                        {
                            continue;
                        }
                        if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == DGVAux.CurrentCell.Value.ToString())
                        {
                           // MessageBox.Show("id repetido");
                            Total -= float.Parse(DGVAux.Rows[DGVAux.CurrentRow.Index].Cells[3].Value.ToString()) * float.Parse(DGVAux.Rows[DGVAux.CurrentRow.Index].Cells[2].Value.ToString());
                           
                            DGVAux.Rows.Remove(DGVAux.CurrentRow);
                        }
                    }
                }
            }
           
            Total += float.Parse(DGVTotalProductos.Rows[e.RowIndex].Cells[3].Value.ToString())   *  float.Parse(DGVAux.Rows[DGVAux.CurrentRow.Index].Cells[2].Value.ToString());
            lblTotal.Text = Total.ToString();
           
        }
        public FileInfo MakeUnique(string path)
        {
            string dir = Path.GetDirectoryName(path);
            string filename = Path.GetFileNameWithoutExtension(path);
            string fileExt = Path.GetExtension(path);

            for (int i = 1; ; ++i)
            {
                if (!File.Exists(path))
                    return new FileInfo(path);

                path = Path.Combine(dir, filename + " " + i + fileExt);
            }
        }
        public void EnvioCorreo()
        {
            var fromAddress = new MailAddress("PruebaCarlos98@gmail.com", "Empresa X");
            var toAddress = new MailAddress(txtCorreo.Text, "Cliente");
            const string fromPassword = "prueba123";
            const string subject = "Esta es tu Factura";
            const string body = "Solo con fines de prueba";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {

                Subject = subject,
                Body = body

            })

            {
                var fecha = DateTime.Now.ToString("hhmm");
                string path= "PDFS\\" +filename + "_" + fecha + ".pdf" ;
                message.Attachments.Add(new System.Net.Mail.Attachment(path));
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Correo Enviado con Exito");
                }
                catch
                {
                    MessageBox.Show("Error al enviar correo porfavor verifique conexion a internet...");
                }
            }
        }
        //Generacion de PDF (utiliza una libreria especial que se encuentra en la carpeta de packages llamada iTextSharp
        private void To_pdf()
        {

            int ContFac = 0;
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            ContFac++;

            filename = txtRFC.Text;
            var fecha = DateTime.Now.ToString("hhmm");
            
            PdfWriter writer = PdfWriter.GetInstance(doc,
                            new FileStream(@".\PDFS\" + filename + "_" + fecha+ ".pdf", FileMode.Create));
            if (filename.Trim() != "")
            {   
                doc.Open();
                string envio = "Fecha:   " + DateTime.Now.ToString();

                Chunk chunk = new Chunk("Factura del cliente:", FontFactory.GetFont("Century Gothic", 18, iTextSharp.text.Font.BOLD));
                doc.Add(new Paragraph(chunk));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("          RFC: "+txtRFC.Text));
                doc.Add(new Paragraph("          Correo: " + txtCorreo.Text));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph(envio));
                doc.Add(new Paragraph("------------------------------------------------------------------------------------------"));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("                       "));
                GenerarDocumento(doc);
                doc.Add(new Paragraph("                       "));
                doc.Add(new Paragraph("           Total: "+lblTotal.Text));
                doc.AddCreationDate();


                doc.Close();   
            }

        }
        public void GenerarDocumento(Document document)
        {
            int i, j;
            PdfPTable datatable = new PdfPTable(DGVAux.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas(DGVAux);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (i = 0; i < DGVAux.ColumnCount; i++)
            {
                datatable.AddCell(DGVAux.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (i = 0; i < DGVAux.Rows.Count; i++)
            {
                for (j = 0; j < DGVAux.Columns.Count; j++)
                {
                    if (DGVAux[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(DGVAux[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                    }
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
        }
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;

        }

        public static bool ComprobarFormatoEmail(string email)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (System.Text.RegularExpressions.Regex.IsMatch(email, sFormato))
            {
                if (System.Text.RegularExpressions.Regex.Replace(email, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Correo en el formato Incorrecto");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Correo en el formato Incorrecto");
                return false;
            }
        }
        static bool validarRFC(string RFC)
        {
            try
            {
                if (RFC.Length >= 12 && RFC.Length<=13)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("RFC incorrecto");
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("RFC incorrecto, debe ingresar de 12 a 13 letras");
                return false;
            }
        }
        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            
            if(ComprobarFormatoEmail(txtCorreo.Text) == false || validarRFC(txtRFC.Text)==false)
            {

            }
            else { 
            lblCantidad_P.Text = "";
            int CP = 0;
            clienteTableAdapter1.Insert(txtRFC.Text, txtCorreo.Text);
            clienteTableAdapter1.Fill(factura_clienteDataSet.cliente);
            dataGridView1.DataSource = factura_clienteDataSet.Tables[0];

            clienteTableAdapter1.Update(factura_clienteDataSet);
            factura_clienteDataSet.AcceptChanges();

            //  MessageBox.Show("registro exitoso");
            for (int i = 0; i < DGVAux.RowCount; i++)
            {
                CP += int.Parse(DGVAux.Rows[i].Cells[2].Value.ToString());
                lblCantidad_P.Text = CP.ToString();
            }
                var fecha = DateTime.Now.ToString("hhmm");
            preFacturaTableAdapter.Insert(txtRFC.Text, txtCorreo.Text, CP, decimal.Parse(lblTotal.Text), @".\PDFS\" + filename + "_" + fecha + ".pdf");
            preFacturaTableAdapter.Fill(factura_clienteDataSet.PreFactura);
            preFacturaDataGridView.DataSource = factura_clienteDataSet.Tables[2];
            preFacturaTableAdapter.Update(factura_clienteDataSet);
            factura_clienteDataSet.AcceptChanges();

             To_pdf();
            EnvioCorreo();

            if (conexionTcp.TcpClient.Connected)
            {
                var msgPack = new Paquete("login", string.Format("{0},{1},{2},{3}", txtRFC.Text, txtCorreo.Text,lblCantidad_P.Text,lblTotal.Text));
                conexionTcp.EnviarPaquete(msgPack);
            }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
            Environment.Exit(0);
            
        }

        private void DGVAux_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (DGVAux.Rows.Count > 0 && btnConectar.Enabled==false)
            {
                btn_Aceptar.Enabled = true;
            }
            
        }

        private void DGVAux_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (DGVAux.Rows.Count <= 0)
            {
                btn_Aceptar.Enabled = false;
            }
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            
        }
        private void MensajeRecibido(string datos)
        {
            var paquete = new Paquete(datos);
            string comando = paquete.Comando;
            if (comando == "resultado")
            {
                string contenido = paquete.Contenido;

                Invoke(new Action(() => label1.Text = string.Format("Respuesta: {0}", contenido)));
            }
        }
        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }
        public void removeObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            PORT = int.Parse(txtPuerto.Text);
            IPADDRESS = txtIpServer.Text;
            if (!conexionTcp.Connectar(IPADDRESS, PORT))
            {
                observers.RemoveAt(i);
            }
        }
        private void BtnConectar_Click(object sender, EventArgs e)
        {
            DGVTotalProductos.Visible = true;
            PORT = int.Parse(txtPuerto.Text);
            IPADDRESS = txtIpServer.Text;
            conexionTcp.OnDataRecieved += MensajeRecibido;

           
            if (!conexionTcp.Connectar(IPADDRESS, PORT))
            {
               
                DGVTotalProductos.Visible = false;
                btn_Aceptar.Enabled = false;
                btnConectar.Enabled = true;
                MessageBox.Show("Error conectando con el servidor");
                return;
            }
            else
            {
                btnConectar.Enabled = false;
                MessageBox.Show("Conexion Establecida");
            }
        }
    

        private void ClienteForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnCorreo_Click(object sender, EventArgs e)
        {

        }
    }
}
