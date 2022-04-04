using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Ophthalmology
{
    public  class CustomDateTimePicker: DateTimePicker
    {

           //Значения
        //Поля для внешнего вида
        //Фоновый цвет
        private Color skinColor = Color.MediumSlateBlue;
        //Цвета текста
        private Color txtColor = Color.White;
        //границы и размер границы цвета
        private Color borderColors = Color.PaleVioletRed;
        private int borderSize = 0;

        //Поля для хранения других значений элементов управления
        //Поле которое нужно получить или установить
        private bool droppedDown = false;
        //Поле чтобы сохранить значок выбора дата как значение по умолчанию, значки которые храняться в Ресурсах
        private Image calendarIcon = Properties.Resources.calendarWhite;
        //Прямоугольник для хранения площади 
        private RectangleF iconButtonArea;
        //Целочисленная константа для установления ширины значка 
        private const int calendarIconWidth = 34;
        //Константа, чтобы установить ширину значка стрелки 
        private const int arrowiconwidth = 17;


         //Характеристики
        public Color SkinColor 
        { 
            get => skinColor;
            set
            {
                skinColor = value;
                //Устанавлием значок либо темным, либо светлым в зависимости от тоно фонового цвета
                //Для этого получаем яркость цвета
                //Если яркость цвета равна 0.8, то значек будет тёмным 
                if(skinColor.GetBrightness()>=0.8)
                {
                    calendarIcon = Properties.Resources.calendarDark;
                }    
                else
                {
                    calendarIcon = Properties.Resources.calendarWhite;
                }
                //Вызывыем метод недействительности перерисовать элемент управления
                //Обновляем его внешний вид
                this.Invalidate();
            } 
        }
        public Color TxtColor 
        { 
            get => txtColor;
            set 
            {
                 txtColor = value;
                 this.Invalidate();
            }
            
        }
        public Color BorderColors 
        { 
            get => borderColors;
            set
            {
                borderColors = value;
                this.Invalidate();
            }
        }
        public int BorderSize 
        { 
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        //Конструктор
        public CustomDateTimePicker()
        {
            //Стиль и управление поведением 
            //Элемент управления будет окрашен пользователем 
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0,25);
            //Шрифт
            this.Font = new Font(this.Font.Name, 9.5F);
        }

            //override Методы 
        //Событие просадки происходит, когда показывает раскрывающийся календарь
        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            droppedDown = true;
        }
        //Событие закрытия при закрытие календаря раскрывающегося списка 
        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            droppedDown = false;
        }
        //Событие, чтобы избежать изменения значения выбора даты с ключами числовой
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }
        //Отменяем метод события рисования 
        protected override void OnPaint(PaintEventArgs e)
        {
            //Создаем графический объект для контроля 
            using(Graphics  graphics=this.CreateGraphics())
            //Объект для рисования границы элемента управления цветом и указанный размер границы
            using (Pen penBorder = new Pen(borderColors, borderSize))
            //Кисть для рисования фона управления 
            using(SolidBrush skinBrush=new SolidBrush(skinColor))
            //Ещё один объект кисти для рисования цвета фона значка 
            using(SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50,64,64,64)))
            //Кисть для того чтобы нарисовать текст селектора 
            using(SolidBrush textBrush = new SolidBrush(txtColor))
            //Объект для формата текста 
            using(StringFormat textFormat= new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5F, this.Height - 0.5F);
                RectangleF iconArea = new RectangleF(clientArea.Width-calendarIconWidth,0,calendarIconWidth,clientArea.Height);
                //Устанавливаем выравнивание к внутренней календарю
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;

                //Рисование поверхности 
                graphics.FillRectangle(skinBrush,clientArea);
                //Рисование текста
                graphics.DrawString(" "+this.Text, this.Font, textBrush, clientArea, textFormat);
                //Рисование открывающегося календаря  
                //Проверка когда календарь открывается
                if (droppedDown == true)
                {
                    graphics.FillRectangle(openIconBrush, iconArea);
                }
                //Рисование границ
                //Проверяем соответствует ли значение размера края
                if(borderSize>=1)
                {
                    graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                }
                //Рисование иконки
                graphics.DrawImage(calendarIcon, this.Width - calendarIcon.Width - 9, (this.Height - calendarIcon.Height) / 2);
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconWidth = GetIconButtonWidth();
            iconButtonArea = new RectangleF(this.Width - iconWidth, 0, iconWidth, this.Height);
        }
        //Отменяем событие цикла мыши 
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if(iconButtonArea.Contains(e.Location))
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }
        //Метод для установления размера с размером шрифта
        private int GetIconButtonWidth()
        {
            int textWidth = TextRenderer.MeasureText(this.Text, this.Font).Width;
            if(textWidth<=this.Width-(calendarIconWidth+20))
            {
                return calendarIconWidth;
            }
            else
            {
                return arrowiconwidth;
            }
        }
    }
}
