using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DD_Destroyer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_auswaehlen_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.ShowDialog();
			tb_directory.Text = folderBrowserDialog1.SelectedPath;
		}

		private void btn_start_Click(object sender, EventArgs e)
		{
			try
			{
				if (tb_directory.Text != "")
				{
                    lb_path.Items.Clear();
                    lb_allfound.Items.Clear();

					//bekommt alle unterordner
					DirectoryInfo dir = new DirectoryInfo(tb_directory.Text);

					IEnumerable<FileInfo> fileList = dir.GetFiles("*.*", SearchOption.AllDirectories);

					int charsToSkip = tb_directory.Text.Length;

					var queryDupNames = from file in fileList
										group file.FullName.Substring(charsToSkip) by file.Name
											into fileGroup
											where fileGroup.Count() > 1
											select fileGroup;

					 foreach (var queryDupName in queryDupNames)
					{
						lb_allfound.Items.Add(queryDupName.Key);
						foreach (var file in fileList)
						{
							if (file.Name == queryDupName.Key)
							{
								lb_path.Items.Add(file.Directory);
							}
						}
						lb_path.Items.Add("_______________________________");
					}

                    if (lb_allfound.Items.Count == 0)
                    {
                        MessageBox.Show("Es wurden keine Duplikate gefunden!");
                    }
				}
				else
				{
					MessageBox.Show("Wähle ein Verzeichnis aus!");
				}
			}
			catch (Exception exeption)
			{
				MessageBox.Show(exeption.ToString());
			}
			
			
		}
	}
}
