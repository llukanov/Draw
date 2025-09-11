using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Draw
{
	/// <summary>
	/// Върху главната форма е поставен потребителски контрол,
	/// в който се осъществява визуализацията
	/// </summary>
	public partial class MainForm : Form
	{
		/// <summary>
		/// Агрегирания диалогов процесор във формата улеснява манипулацията на модела.
		/// </summary>
		private DialogProcessor dialogProcessor = new DialogProcessor();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		/// <summary>
		/// Изход от програмата. Затваря главната форма, а с това и програмата.
		/// </summary>
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		
		/// <summary>
		/// Събитието, което се прихваща, за да се превизуализира при изменение на модела.
		/// </summary>
		void ViewPortPaint(object sender, PaintEventArgs e)
		{
			dialogProcessor.ReDraw(sender, e);
		}
		
		/// <summary>
		/// Бутон, който поставя на произволно място правоъгълник със зададените размери.
		/// Променя се лентата със състоянието и се инвалидира контрола, в който визуализираме.
		/// </summary>
		void DrawRectangleSpeedButtonClick(object sender, EventArgs e)
		{
			dialogProcessor.AddRandomRectangle();
			
			statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";
			
			viewPort.Invalidate();
		}

		/// <summary>
		/// Прихващане на координатите при натискането на бутон на мишката и проверка (в обратен ред) дали не е
		/// щракнато върху елемент. Ако е така то той се отбелязва като селектиран и започва процес на "влачене".
		/// Промяна на статуса и инвалидиране на контрола, в който визуализираме.
		/// Реализацията се диалогът с потребителя, при който се избира "най-горния" елемент от екрана.
		/// </summary>
		/// 
		void ViewPortMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (pickUpSpeedButton.Checked) {
				dialogProcessor.Selection = dialogProcessor.ContainsPoint(e.Location);
				if (dialogProcessor.Selection != null) {
					statusBar.Items[0].Text = "Последно действие: Селекция на примитив";
					dialogProcessor.IsDragging = true;
					dialogProcessor.LastLocation = e.Location;
					viewPort.Invalidate();
				}
			}


			switch(statusBar.Items[0].Text)
			{
				case "Последно действие: Оцветяване в синьо":
                    dialogProcessor.ColorShapeBlue(e.Location);

                    statusBar.Items[0].Text = "Последно действие: Оцветено в синьо";

                    viewPort.Invalidate();
                    break;
                case "Последно действие: Оцветяване в розово":
                    dialogProcessor.ColorShapePink(e.Location);

                    statusBar.Items[0].Text = "Последно действие: Оцветено в розово";

                    viewPort.Invalidate();
                    break;
                case "Последно действие: Оцветяване в червено":
                    dialogProcessor.ColorShapeRed(e.Location);

                    statusBar.Items[0].Text = "Последно действие: Оцветено в червено";

                    viewPort.Invalidate();
                    break;
                case "Последно действие: Оцветяване в случаен цвят":
                    dialogProcessor.ColorShapeRandom(e.Location);

                    statusBar.Items[0].Text = "Последно действие: случаен цвят";

                    viewPort.Invalidate();
                    break;
                case "Последно действие: Намаляване":
                    dialogProcessor.DoShapeSmaller(e.Location);

                    // statusBar.Items[0].Text = "Последно действие: Намалена фигура";

                    viewPort.Invalidate();
                    break;
                case "Последно действие: Уголемяване":
                    dialogProcessor.DoShapeBigger(e.Location);

                    // statusBar.Items[0].Text = "Последно действие: Уголемена фигура";

                    viewPort.Invalidate();
                    break;
                case "Последно действие: Прозрачност":
                    dialogProcessor.DoShapeTransparent(e.Location);

                    statusBar.Items[0].Text = "Последно действие: Фигурата е прозрачна";

                    viewPort.Invalidate();
                    break;
                case "Последно действие: Изтриване на фигура":
                    dialogProcessor.DeleteShape(e.Location);

                    statusBar.Items[0].Text = "Последно действие: Фигурата е изтрита";

                    viewPort.Invalidate();
                    break;
                case "Последно действие: Групиране на фигури":
                    dialogProcessor.GroupShapes(e.Location);

                    viewPort.Invalidate();
                    break;
                case "Последно действие: Разгрупиране на фигури":
                    dialogProcessor.UnGroupShape(e.Location);

                    viewPort.Invalidate();
                    break;

            }
		}

		/// <summary>
		/// Прихващане на преместването на мишката.
		/// Ако сме в режм на "влачене", то избрания елемент се транслира.
		/// </summary>
		void ViewPortMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (dialogProcessor.IsDragging) {
				if (dialogProcessor.Selection != null) statusBar.Items[0].Text = "Последно действие: Влачене";
				dialogProcessor.TranslateTo(e.Location);
				viewPort.Invalidate();
			}
		}

		/// <summary>
		/// Прихващане на отпускането на бутона на мишката.
		/// Излизаме от режим "влачене".
		/// </summary>
		void ViewPortMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dialogProcessor.IsDragging = false;
		}

        private void viewPort_Load(object sender, EventArgs e)
        {

        }

        private void DrawEllipseButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddEllipse();

            statusBar.Items[0].Text = "Последно действие: Рисуване на елипса";

            viewPort.Invalidate();
        }

        private void DrawCircleButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddCicle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на кръг";

            viewPort.Invalidate();
        }

        private void DrawSquareButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddSquare();

            statusBar.Items[0].Text = "Последно действие: Рисуване на квадрат";

            viewPort.Invalidate();
        }

        private void ColorBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar.Items[0].Text = "Последно действие: Оцветяване в синьо";
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar.Items[0].Text = "Последно действие: Оцветяване в червено";
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar.Items[0].Text = "Последно действие: Оцветяване в розово";
        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar.Items[0].Text = "Последно действие: Оцветяване в случаен цвят";
        }

        private void DoSmallerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar.Items[0].Text = "Последно действие: Намаляване";
        }

        private void DoBiggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar.Items[0].Text = "Последно действие: Уголемяване";
        }

        private void DoShapeTransparentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBar.Items[0].Text = "Последно действие: Прозрачност";
        }

        private void DeleteShapeButton_Click(object sender, EventArgs e)
        {
            statusBar.Items[0].Text = "Последно действие: Изтриване на фигура";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void speedMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DrawTriangleButton_Click(object sender, EventArgs e)
        {
            dialogProcessor.AddTriangle();

            statusBar.Items[0].Text = "Последно действие: Рисуване на триъгълник";

            viewPort.Invalidate();
        }

        private void GroupShapesButton_Click(object sender, EventArgs e)
        {
            statusBar.Items[0].Text = "Последно действие: Групиране на фигури";
        }

        private void UnGroupShapeButton_Click(object sender, EventArgs e)
        {
            statusBar.Items[0].Text = "Последно действие: Разгрупиране на фигури";
        }

        private void doSmallerButton_Click(object sender, EventArgs e)
        {
            statusBar.Items[0].Text = "Последно действие: Намаляване";
        }

        private void doBiggerButton_Click(object sender, EventArgs e)
        {
            statusBar.Items[0].Text = "Последно действие: Уголемяване";
        }
    }
}
