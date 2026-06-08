using System;
using System.IO;
using System.Windows.Forms;
using VectorLabWinForms.Models;
using Microsoft.VisualBasic;

namespace VectorLabWinForms
{
    public partial class Form1 : Form
    {
        private IVectorable currentVector;
        private IVectorable clonedVector;

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dgvElements.ColumnCount = 1;
            dgvElements.Columns[0].Name = "Значение";
            dgvElements.Columns[0].Width = 150;
        }

        private void btnCreateGrid_Click(object sender, EventArgs e)
        {
            try
            {
                int size = (int)nudSize.Value;
                dgvElements.Rows.Clear();
                dgvElements.Rows.Add(size);

                for (int i = 0; i < size; i++)
                {
                    dgvElements.Rows[i].HeaderCell.Value = (i + 1).ToString();
                    dgvElements.Rows[i].Cells[0].Value = 0;
                }

                rtbOutput.AppendText($"Создана таблица для {size} элементов\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowVector_Click(object sender, EventArgs e)
        {
            try
            {
                int size = (int)nudSize.Value;

                if (rbArray.Checked)
                    currentVector = new ArrayVector(size);
                else
                    currentVector = new LinkListVector(size);

                for (int i = 0; i < size; i++)
                {
                    if (dgvElements.Rows[i].Cells[0].Value != null)
                    {
                        int value = Convert.ToInt32(dgvElements.Rows[i].Cells[0].Value);
                        currentVector[i + 1] = value;
                    }
                }

                rtbOutput.AppendText($"\n Вектор: {currentVector}\n");
                rtbOutput.AppendText($" Длина: {currentVector.Length}\n");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: введите числа во все ячейки!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNorm_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentVector == null)
                {
                    MessageBox.Show("Сначала создайте вектор (кнопка 'Показать вектор')", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                double norm = currentVector.GetNorm();
                rtbOutput.AppendText($"Модуль вектора: {norm:F3}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentVector == null)
                {
                    MessageBox.Show("Сначала создайте вектор", "Внимание");
                    return;
                }

                clonedVector = (IVectorable)((ICloneable)currentVector).Clone();
                rtbOutput.AppendText($"\n🔬 Клон создан: {clonedVector}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка клонирования: {ex.Message}", "Ошибка");
            }
        }

        private void btnModifyClone_Click(object sender, EventArgs e)
        {
            try
            {
                if (clonedVector == null)
                {
                    MessageBox.Show("Сначала создайте клон", "Внимание");
                    return;
                }

                string indexStr = Microsoft.VisualBasic.Interaction.InputBox("Введите индекс (1-" + clonedVector.Length + ")", "Изменение клона", "1");
                string valueStr = Microsoft.VisualBasic.Interaction.InputBox("Введите новое значение", "Изменение клона", "0");

                int index = int.Parse(indexStr);
                int value = int.Parse(valueStr);

                clonedVector[index] = value;

                rtbOutput.AppendText($"\n Клон изменён: {clonedVector}\n");
                rtbOutput.AppendText($" Оригинал остался: {currentVector}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }

        private void btnByteWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentVector == null || !(currentVector is ArrayVector))
                {
                    MessageBox.Show("Байтовый поток работает только с ArrayVector. Создайте ArrayVector.", "Внимание");
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Бинарные файлы|*.bin|Все файлы|*.*";
                sfd.DefaultExt = "bin";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        Vector.OutputVector((ArrayVector)currentVector, fs);
                    }
                    rtbOutput.AppendText($" Вектор сохранён в байтовый файл: {sfd.FileName}\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при записи: {ex.Message}", "Ошибка");
            }
        }

        private void btnByteRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Бинарные файлы|*.bin|Все файлы|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
                    {
                        ArrayVector loadedVector = Vector.InputVector(fs);
                        currentVector = loadedVector;

                        nudSize.Value = loadedVector.Length;
                        btnCreateGrid_Click(null, null);
                        for (int i = 0; i < loadedVector.Length; i++)
                        {
                            dgvElements.Rows[i].Cells[0].Value = loadedVector[i + 1];
                        }

                        rtbOutput.AppendText($" Загружен вектор из байтового файла: {loadedVector}\n");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Файл не найден!", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении: {ex.Message}", "Ошибка");
            }
        }

        private void btnTextWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentVector == null || !(currentVector is ArrayVector))
                {
                    MessageBox.Show("Текстовый поток работает только с ArrayVector", "Внимание");
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        Vector.WriteVector((ArrayVector)currentVector, sw);
                    }
                    rtbOutput.AppendText($"Вектор сохранён в текстовый файл: {sfd.FileName}\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }

        private void btnTextRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        ArrayVector loadedVector = Vector.ReadVector(sr);
                        currentVector = loadedVector;

                        nudSize.Value = loadedVector.Length;
                        btnCreateGrid_Click(null, null);
                        for (int i = 0; i < loadedVector.Length; i++)
                        {
                            dgvElements.Rows[i].Cells[0].Value = loadedVector[i + 1];
                        }

                        rtbOutput.AppendText($" Загружен вектор из текстового файла: {loadedVector}\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }

        private void btnJsonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentVector == null)
                {
                    MessageBox.Show("Нет вектора для сохранения", "Внимание");
                    return;
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "JSON файлы|*.json|Все файлы|*.*";
                sfd.FileName = rbArray.Checked ? "arrayvector.json" : "linkedlistvector.json";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (currentVector is ArrayVector av)
                        Vector.SerializeArrayVector(av, sfd.FileName);
                    else if (currentVector is LinkListVector llv)
                        Vector.SerializeLinkedListVector(llv, sfd.FileName);

                    rtbOutput.AppendText($"💾 Вектор сохранён в JSON: {sfd.FileName}\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка JSON: {ex.Message}", "Ошибка");
            }
        }

        private void btnJsonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JSON файлы|*.json|Все файлы|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = ofd.FileName;
                    string json = File.ReadAllText(fileName);

                    if (json.Contains("\"coordinates\""))
                    {
                        ArrayVector loaded = Vector.DeserializeArrayVector(fileName);
                        currentVector = loaded;
                        rbArray.Checked = true;
                        rtbOutput.AppendText($"📂 Загружен ArrayVector: {loaded}\n");
                    }
                    else
                    {
                        LinkListVector loaded = Vector.DeserializeLinkedListVector(fileName);
                        currentVector = loaded;
                        rbLinkedList.Checked = true;
                        rtbOutput.AppendText($"Загружен LinkedListVector: {loaded}\n");
                    }

                    nudSize.Value = currentVector.Length;
                    btnCreateGrid_Click(null, null);
                    for (int i = 0; i < currentVector.Length; i++)
                    {
                        dgvElements.Rows[i].Cells[0].Value = currentVector[i + 1];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки JSON: {ex.Message}", "Ошибка");
            }
        }
    }
}
