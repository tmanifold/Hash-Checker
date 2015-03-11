using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.IO;

namespace Hash_Checker
{
    public partial class frmHashChekerForm : Form
    {
        private struct Algorithms
        {
            public static readonly HashAlgorithm MD5 = new MD5CryptoServiceProvider();
            public static readonly HashAlgorithm SHA1 = new SHA1Managed();
            public static readonly HashAlgorithm SHA256 = new SHA256Managed();
            public static readonly HashAlgorithm SHA384 = new SHA384Managed();
            public static readonly HashAlgorithm SHA512 = new SHA512Managed();
            public static readonly HashAlgorithm RIPEMD160 = new RIPEMD160Managed();
        }   

        private static string hashfile = null;

        public frmHashChekerForm()
        {
            InitializeComponent();
        }

        private void txtHashTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmHashChekerForm_Load(object sender, EventArgs e)
        {
            txtHashTextBox.BackColor = this.BackColor;
        }

        private void btnBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();

            string file = dlg.FileName;
            
            txtFileTextBox.Text = Path.GetFullPath(file);
            hashfile = Path.GetFullPath(file);

        }

        private void btnCheckHashButton_Click(object sender, EventArgs e)
        {
            txtHashTextBox.ForeColor = System.Drawing.Color.Black;
            HashAlgorithm alg;

            try
            {
                string type = cmbHashTypeComboBox.SelectedItem.ToString();

                switch (type)
                {
                    case "MD5":
                        {
                            alg = Algorithms.MD5;
                            break;
                        }
                    case "SHA1":
                        {
                            alg = Algorithms.SHA1;
                            break;
                        }
                    case "SHA256":
                        {
                            alg = Algorithms.SHA256;
                            break;
                        }
                    case "SHA384":
                        {
                            alg = Algorithms.SHA384;
                            break;
                        }
                    case "SHA512":
                        {
                            alg = Algorithms.SHA512;
                            break;
                        }
                    case "RIPEMD160":
                        {
                            alg = Algorithms.RIPEMD160;
                            break;
                        }
                    default:
                        {
                            alg = Algorithms.MD5;
                            break;
                        }

                }


                txtHashTextBox.Text = GetHashFromFile(hashfile, alg);
            }
            catch (System.ArgumentNullException) { }
            catch (System.NullReferenceException) { }

            if (txtHashCheckTextBox.Text.ToUpper() == txtHashTextBox.Text)
            {
                txtHashTextBox.ForeColor = System.Drawing.Color.Green;
            }
        }

        private string GetHashFromFile(string file, HashAlgorithm algorithm)
        {
            using (var stream = new BufferedStream(File.OpenRead(file), 100000))
            {
                return BitConverter.ToString(algorithm.ComputeHash(stream)).Replace("-", string.Empty);
            }
            
        }

    }
}
