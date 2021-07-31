using System;
using System.Windows.Forms;
using System.Drawing;


namespace helooword
{
    public static class class1
    {    public static int x , y,r ;
         public static string oper ;


      public static void Main(string[] args)
      { 
        /*desing.............................................*/
         Form fr = new Form();
         
        
         TextBox tb = new TextBox();
         tb.Font = new Font("Tahoma",20);
         tb.Multiline = true;
         tb.Width = 200;
         tb.Height = 40;
         tb.Left = 30;
         tb.Top = 10;
        
        
         Button btn1 = new Button();
         btn1.Font = new Font("Tahoma",14);
         btn1.Text = "1";
         btn1.Width = 40;
         btn1.Height= 40 ;
         btn1.Top = 170;
         btn1.Left = 5;

         Button btn2 = new Button();
         btn2.Font = new Font("Tahoma",14);
         btn2.Text = "2";
         btn2.Width = 40;
         btn2.Height= 40 ;
         btn2.Top = 170;
         btn2.Left = 55;

         Button btn3 = new Button();
         btn3.Font = new Font("Tahoma",14);
         btn3.Text = "3";
         btn3.Width = 40;
         btn3.Height= 40;
         btn3.Top = 170;
         btn3.Left = 105;

           Button btn4 = new Button();
         btn4.Font = new Font("Tahoma",14);
         btn4.Text = "4";
         btn4.Width = 40;
         btn4.Height= 40 ;
         btn4.Top = 120;
         btn4.Left = 5;

          Button btn5 = new Button();
         btn5.Font = new Font("Tahoma",14);
         btn5.Text = "5";
         btn5.Width = 40;
         btn5.Height= 40 ;
         btn5.Top = 120;
         btn5.Left = 55;

          Button btn6 = new Button();
         btn6.Font = new Font("Tahoma",14);
         btn6.Text = "6";
         btn6.Width = 40;
         btn6.Height= 40 ;
         btn6.Top = 120;
         btn6.Left = 105;

          Button btn7 = new Button();
         btn7.Font = new Font("Tahoma",14);
         btn7.Text = "7";
         btn7.Width = 40;
         btn7.Height= 40 ;
         btn7.Top = 70;
         btn7.Left = 5;

         Button btn8 = new Button();
         btn8.Font = new Font("Tahoma",14);
         btn8.Text = "8";
         btn8.Width = 40;
         btn8.Height= 40 ;
         btn8.Top = 70;
         btn8.Left = 55;

         Button btn9 = new Button();
         btn9.Font = new Font("Tahoma",14);
         btn9.Text = "9";
         btn9.Width = 40;
         btn9.Height= 40 ;
         btn9.Top = 70;
         btn9.Left = 105;

         Button btn0 = new Button();
         btn0.Font = new Font("Tahoma",14);
         btn0.Text = "0";
         btn0.Width = 40;
         btn0.Height= 40 ;
         btn0.Top = 220;
         btn0.Left = 55;
     
  
        Button pls = new Button();
         pls.Font = new Font("Tahoma",14); 
         pls.Text = "+" ;
         pls.Width = 50;
         pls.Height = 40;
         pls.Top = 200;
         pls.Left = 155;

          Button min = new Button();
         min.Font = new Font("Tahoma",14); 
         min.Text = "-" ;
         min.Width = 50;
         min.Height = 40;
         min.Top = 150;
         min.Left = 155;

          Button mul = new Button();
         mul.Font = new Font("Tahoma",14); 
         mul.Text = "*" ;
         mul.Width = 50;
         mul.Height = 40;
         mul.Top = 100;
         mul.Left = 155;
         
         Button eql = new Button();
         eql.Font = new Font("Tahoma",14); 
         eql.Text = "=" ;
         eql.Width = 50;
         eql.Height = 80;
         eql.Top = 160;
         eql.Left = 215;

          Button clr = new Button();
         clr.Font = new Font("Tahoma",14); 
         clr.Text = "clear" ;
         clr.Width = 60;
         clr.Height = 80;
         clr.Top = 70;
         clr.Left = 215;



         fr.Controls.Add(tb);
         fr.Controls.Add(btn1);
         fr.Controls.Add(btn2);
         fr.Controls.Add(btn3);
         fr.Controls.Add(btn4);
         fr.Controls.Add(btn5);
         fr.Controls.Add(btn6);
         fr.Controls.Add(btn7);
         fr.Controls.Add(btn8);
         fr.Controls.Add(btn9);
         fr.Controls.Add(btn0);
         fr.Controls.Add(pls);
         fr.Controls.Add(min);
         fr.Controls.Add(mul);
         fr.Controls.Add(eql);
         fr.Controls.Add(clr);

         /*coding.............................................................*/
          
          btn1.Click += delegate {
           tb.Text += "1";
           };
           btn2.Click += delegate {
           tb.Text += "2";
            };
            btn3.Click += delegate {
           tb.Text += "3";
            };
            btn4.Click += delegate {
           tb.Text += "4";
            };
            btn5.Click += delegate {
           tb.Text += "5";
            };
            btn6.Click += delegate {
           tb.Text += "6";
            };
            btn7.Click += delegate {
           tb.Text += "7";
            };
            btn8.Click += delegate {
           tb.Text += "8";
            };
            btn9.Click += delegate {
           tb.Text += "9";
            };
            btn0.Click += delegate {
           tb.Text += "0";
            };



         pls.Click +=delegate{
              x += int.Parse(tb.Text);
              foreach (Control c in fr.Controls )
              {
                  if (c is TextBox)
                  {
                      c.Text = "";
                  }
              }
               oper = "+";
             
            };

            min.Click += delegate{
              x += int.Parse(tb.Text);
              foreach (Control c in fr.Controls )
              {
                  if (c is TextBox)
                  {
                      c.Text = "";
                  }
              }
               oper = "-";
             
            };

            mul.Click += delegate{
              x += int.Parse(tb.Text);
              foreach (Control c in fr.Controls )
              {
                  if (c is TextBox)
                  {
                      c.Text = "";
                  }
              }
               oper = "*";
             
            };


         eql.Click += delegate{

           y=int.Parse(tb.Text);
             foreach (Control c in fr.Controls )
              {
                  if (c is TextBox)
                  {
                      c.Text = "";
                  }
              }

              if (oper == "+")
              { 
                  r=x+y;
              string res ; 
              res = Convert.ToString(r);
              tb.Text = res ;
                  oper = null;
                  x=0;
                  
                  
              }
              else if(oper == "-") { 
                  r=x-y;
              string res ; 
              res = Convert.ToString(r);
              tb.Text = res ;
                   oper = null;
                  x=0;
              }
              else if(oper == "*") { 
                  r=x*y;
              string res ; 
              res = Convert.ToString(r);
              tb.Text = res ;
                   oper = null;
                 x=0;
              }else{

                  foreach (Control c in fr.Controls )
              {
                  if (c is TextBox)
                  {
                      c.Text = null;
                  }
              }
              }


            

            
              

         };

         clr.Click += delegate {
           foreach (Control c in fr.Controls )
              {
                  if (c is TextBox)
                  {
                      c.Text = null;
                  }
              }
           };

                                   






         fr.ShowDialog();
         
   
      




      }



    }
}