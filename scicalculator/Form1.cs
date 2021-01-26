using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scicalculator
{
    public partial class SciCalculator : Form
    {
        Stack<char> op = new Stack<char>();//运算符栈
        Stack<double> st = new Stack<double>();//运算数栈
        string exp;
        char[] postexp=new char[100];
        int pnum=0;//postexp中字符个数
        double ans = 0;
        static int Base = 10;

        public  double   fact(double    n)//阶乘函数
        {
            if (n <= 1) //判断参数是否小于等于一
            {
                return 1;
            }
            else
            {
                return n * fact(n - 1);//自己调用自己并递减
            }
        }

        int BaseTo10(string n, int b)//转为10进制
        {
            
            int s = 0;
            Base = b;

            for (int i = 0; i < n.Length; i++)
            {
                switch (n[i])
                {
                    case '0':
                        break;
                    case '1':
                        s += (int)Math.Pow(b, n.Length - i - 1);
                        break;
                    case '2':
                        s += 2 * (int)Math.Pow(b, n.Length - i - 1);
                        break;
                    case '3':
                        s += 3 * (int)Math.Pow(b, n.Length - i - 1);
                        break;
                    case '4':
                        s += 4 * (int)Math.Pow(b, n.Length - i - 1);
                        break;
                    case '5':
                        s += 5 * (int)Math.Pow(b, n.Length - i - 1);
                        break;
                    case '6':
                        s += 6 * (int)Math.Pow(b, n.Length - i - 1);
                        break;
                    case '7':
                        s += 7 * (int)Math.Pow(b, n.Length - i - 1);
                        break;
                    case '8':
                        s += 8 * (int)Math.Pow(b, n.Length - i - 1);
                        break;
                    case '9':
                        s += 9 * (int)Math.Pow(b, n.Length - i - 1);
                        break;
                    case 'A':
                        s += 10 * (int)Math.Pow(b, n.Length - i - 1);
                        break;
                    case 'B':
                        s += 11 * (int)Math.Pow(b, n.Length - i - 1);
                        break;
                    case 'C':
                        s += 12 * (int)Math.Pow(b, n.Length - i - 1);
                        break;
                    case 'D':
                        s += 13 * (int)Math.Pow(b, n.Length - i - 1);
                        break;
                    case 'E':
                        s += 14 * (int)Math.Pow(b, n.Length - i - 1);
                        break;
                    case 'F':
                        s += 15 * (int)Math.Pow(b, n.Length - i - 1);
                        break;
                }
            }

            return s;
        }

        int Getpri(char cch)
        {
            switch (cch)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                case '%':
                    return 2;
                case 's':
                case 'c':
                case 't':
                case 'i'://AS
                case 'o'://AC
                case 'k'://AT
                case 'g'://log
                case 'l'://ln
                case '!'://阶乘
                case 'p'://科学计数
                    return 3;

                case '^'://幂运算
                case '²'://平方
                case 'q'://开方
                case '¹'://倒数
                    return 4;
                case 'n'://取相反数
                    return 5;
                default:
                    return 0;//j绝对值返回0
            }
        }
        int flag = 0;
        public void Trans()//中缀转后缀
        {
            int i = 0, j = 0;//i j分别作为exp和postexp的下标
            char ch;
            while (i < exp.Length)//表达式未扫描完时循环
            {
                ch = exp[i];
                if (ch == '(')//判定为左括号，优先级最高，直接进栈
                {

                    if ( exp[i+1] == '-' ) flag = 1;//解决出栈为（-）的问题，关键是要判断-是单目还是双目，不知问题是否解决
                    else flag = 0;
                    op.Push(ch);
                    
                }
                else if (ch == ')')//判定为右括号，到此说明要结束本次带括号的运算
                {
                    
                    while (op.Count != 0 && !op.Peek().Equals('(') )
                    {
                        
                        postexp[j++] = op.Pop();                     
                    }
                    
                    op.Pop();//'('出栈

                }

                else if (ch == 'j' )//判断为绝对值号
                {
                    while (op.Count != 0 && !op.Peek().Equals('(') && Getpri(op.Peek()) >= Getpri(ch))//若栈顶存在优先级高或等于+的，则将其退栈
                    {//将栈中'('前面的运算符退栈并存放到postexp中
                        postexp[j++] = op.Pop();

                    }
                    op.Push(ch);//否则，栈顶优先级低，直接将ch进栈

                }

                else if (ch == '+'|| ch == '-')//判断为加减号
                {

                    while (op.Count != 0 && !op.Peek().Equals('(')&&Getpri (op.Peek ()) >= Getpri(ch))//若栈顶存在优先级高或等于+的，则将其退栈
                    {//将栈中'('前面的运算符退栈并存放到postexp中
                        postexp[j++] = op.Pop();

                    }
                    op.Push(ch);//否则，栈顶优先级低，直接将ch进栈

                }

                else if (ch == '*' || ch == '/'||ch=='%')//判断为乘除模号
                {
                    while (op.Count != 0 && !op.Peek().Equals('(')&& Getpri(op.Peek()) >= Getpri(ch))// 栈内优先级高（指大于等于*或/的优先级）则退栈
                     {//将栈中'('前面的运算符退栈并存放到postexp中
                        postexp[j++] = op.Pop();

                    }
                    op.Push(ch);

                }
                else if (ch == 's' || ch == 'c' || ch == 't' || ch == 'i' || ch == 'o' || ch == 'k'||ch == 'l' || ch == 'g' || ch == '!' || ch == 'p')//判断为函数
                {
                    while (op.Count != 0 && !op.Peek().Equals('(') && Getpri(op.Peek()) >= Getpri(ch))// 栈内优先级高（指大于等于某函数的优先级）则退栈
                    {//将栈中'('前面的运算符退栈并存放到postexp中
                        postexp[j++] = op.Pop();

                    }
                    op.Push(ch);

                }

                else if (ch == '^' || ch == '²' || ch == 'q' || ch == '¹')//判断为指数
                {
                    while (op.Count != 0 && !op.Peek().Equals('(') && Getpri(op.Peek()) >= Getpri(ch))// 栈内优先级高（指大于等于某函数的优先级）则退栈
                    {//将栈中'('前面的运算符退栈并存放到postexp中
                        postexp[j++] = op.Pop();

                    }
                    op.Push(ch);

                }
                else if (ch == 'n' || ch == 'j' )//判断为
                {
                    while (op.Count != 0 && !op.Peek().Equals('(') && Getpri(op.Peek()) >= Getpri(ch))// 栈内优先级高（指大于等于某函数的优先级）则退栈
                    {//将栈中'('前面的运算符退栈并存放到postexp中
                        postexp[j++] = op.Pop();

                    }
                    op.Push(ch);

                }

                else
                {
                    while ((ch >= '0' && ch <= '9')||ch=='.'||ch=='Π'||ch=='e')//判断为数字
                    {
                        postexp[j++] = ch;
                        i++;
                        if (i < exp.Length) ch = exp[i];
                        else break;
                    }
                    i--;
                    postexp[j++] = '#';//用#来标识一个数值串结束
                }
                i++;//继续处理其他字符

            }

            while(op.Count ()!=0)
            {
                postexp[j++] = op.Pop();

            }
            pnum = j;

        }
     
        public void GetValue()//计算后缀表达式postexp的值
        {

            double a, b, c, d,d1,d2;
            int i = 0;
            char ch;

            while (i < pnum)//postexp字符串未扫描完时循环
            {
                ch = postexp[i];
                switch (ch)
                {
                    case '+':               //判定为+号
                        a = st.Pop();  //退栈取数值a

                        b = st.Pop();  //退栈取数值b

                        c = a + b;                 //计算c
                        st.Push(c);//将计算结果进栈
                        break;
                    case '-'://判定为-号
                        a = st.Pop();//退栈取数值a
                        if (st.Count() ==0 ||flag==1) b = 0;//这是容易造成bug的一个原因，因为有时候不是单目运算也误判为这种情况了，目前的解决方案没有验证出错
                        else b = st.Pop();//退栈取数值b

                        c = b - a;//计算c

                        st.Push(c);//将计算结果进栈
                        break;
                    case '*'://判定为'*'号
                        a = st.Pop();//退栈取数值a

                        b = st.Pop();//退栈取数值b//退栈取数值b

                        c = a * b;//计算c
                        st.Push(c);//将计算结果进栈
                        break;
                    case '/': //判定为/号
                        a = st.Pop();//退栈取数值a
                        b = st.Pop();//退栈取数值b
                        if (a != 0)
                        {
                            c = b / a;//计算c
                            st.Push(c);//将计算结果进栈
                        }
                        else MessageBox.Show("除数不能为零");//除零错误，返回false
                        break;
                    case '%'://判定为'%'号
                        a = st.Pop();//退栈取数值a

                        b = st.Pop();//退栈取数值b

                        if (a != 0)
                        {
                            c = b % a;//计算c
                            st.Push(c);//将计算结果进栈
                        }
                        else MessageBox.Show("除数不能为零");//除零错误，返回false
                       break;

                    case 'p'://判定为科学计数
                        a = st.Pop();//退栈取数值a

                        b = st.Pop();//退栈取数值b//退栈取数值b

                        c = b * Math .Pow (10,a);//计算c
                        st.Push(c);//将计算结果进栈
                        break;



                    case 's':
                        a = st.Pop();
                        c = Math.Sin(a);
                        st.Push(c);
                        break;

                    case 'c':
                        a = st.Pop();
                        c = Math.Cos (a);
                        st.Push(c);
                        break;
                    case 't':
                        a = st.Pop();
                        c = Math.Tan (a);
                        st.Push(c);
                        break;
                    case 'i':
                        a = st.Pop();
                        c = Math.Asin (a);
                        st.Push(c);
                        break;
                    case 'o':
                        a = st.Pop();
                        c = Math.Acos (a);
                        st.Push(c);
                        break;
                    case 'k':
                        a = st.Pop();
                        c = Math.Atan  (a);
                        st.Push(c);
                        break;
                    case 'l':
                        a = st.Pop();
                        c = Math.Log (a);
                        st.Push(c);
                        break;
                    case 'g':
                        a = st.Pop();
                        c = Math.Log10 (a);
                        st.Push(c);
                        break;
                    case '!':
                        a = st.Pop();

                        if (a < 0)
                        {
                            MessageBox.Show("负数不支持阶乘运算");
                            c = a ;
                        }
                        else
                        {
                            c = fact(a); 
                        }

                        st.Push(c);
                        break;


                    case '¹':
                        a = st.Pop();
                        
                        c = Math.Pow(a, -1);
                        st.Push(c);
                        
                        break;

                    case '²':
                        a = st.Pop();
                        c = Math.Pow(a, 2);
                        st.Push(c);
                        break;
                    case 'q':
                        a = st.Pop();
                        c = Math.Pow(a, 0.5);
                        st.Push(c);
                        break;
                    case '^':
                        a = st.Pop();//退栈取数值a
                        
                        b = st.Pop();//退栈取数值b//退栈取数值b

                        c =Math.Pow (b,a) ;//计算c
                        st.Push(c);//将计算结果进栈
                        break;
                    case 'n':
                        a = st.Pop();//退栈取数值a
                        c = -a ;//计算c
                        st.Push(c);//将计算结果进栈
                        break;
                    case 'j':
                        a = st.Pop();//退栈取数值a
                        c = Math.Abs (a);//计算c
                        st.Push(c);//将计算结果进栈
                        break;

                    default://处理数字字符
                        d = 0; d1 = 0; d2 = 0;//将连续的数字符转换成数值存放到d,d1,d2中,d1为整数部分，d2为小数部分
                        int count = 0;

                        while (ch >= '0' && ch <= '9'||ch=='Π'||ch =='e')
                        {


                            if (ch == 'Π')
                                d1 = Math.PI;
                            else if (ch == 'e')
                                d1 = Math.E;
                            else
                                d1 = 10 * d1 + (ch - '0');
                                i++;
                                ch = postexp[i];
                        }
                        if (ch == '.')
                        {

                           i++;
                           ch = postexp[i];
                           while (ch >= '0' && ch <= '9')
                           {
                              d2 = 10 * d2 + (ch - '0');
                              i++;
                              ch = postexp[i];
                              count++;
                           }
                        }
                            d2 = d2 * Math.Pow(10, -count);
                        
                            d = d1 + d2;
                            st.Push(d);
                        break;
                }
                i++;//继续处理其他字符

            }
            ans = st.Pop ();

        }

        public SciCalculator()
        {
            InitializeComponent();
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            exp += '1';
            TextBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            exp += '2';
            TextBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exp += '3';
            TextBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            exp += '4';
            TextBox.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            exp += '6';
            TextBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            exp += '7';
            TextBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            exp += '8';
           TextBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            exp += '9';
            TextBox.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            exp += '0';
            TextBox.Text += "0";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            exp = "";
            TextBox.Text = "";
            st.Clear();
            op.Clear();
            postexp[0]='\0';
            pnum = 0;//postexp中字符个数
            ans = 0;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            exp += '/';
            TextBox.Text += "/";
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            exp += '.';
            TextBox.Text += '.';
  
        }

        private void button15_Click(object sender, EventArgs e)
        {
            exp += '-';
           TextBox.Text += "-";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            exp += '*';
            TextBox.Text += "*";

        }

        private void button13_Click(object sender, EventArgs e)
        {

            if (TextBox.Text.Length == 0)
            {
                MessageBox.Show("您还未输入");
                return;
            }
            Trans();
            GetValue();

            TextBox.Text += System.Environment.NewLine;
            TextBox.Text += '=';
            TextBox.Text += ans;
            exp = ans.ToString();
            
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                if (exp.Length != 0) exp = exp.Substring(0, exp.Length - 1);
                if (TextBox.Text.Length != 0) TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length - 1);
                else MessageBox.Show("已经为空啦(*^_^*)");
            }
           catch (Exception )//不好排除bug，暂且用try解决
            {
                MessageBox.Show("已经为空啦(*^_^*)");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            exp += '5';
            TextBox.Text += "5";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            exp += '(';
            TextBox.Text += "(";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            exp += '+';
            TextBox.Text += "+";

        }

        private void button28_Click(object sender, EventArgs e)
        {
            exp += 'Π';
            TextBox.Text += 'Π';
        }

        private void button19_Click(object sender, EventArgs e)
        {
            exp += ')';
            TextBox.Text += ")";

        }

        private void button29_Click(object sender, EventArgs e)
        {
           exp += 's';
           TextBox.Text += "sin";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            exp += 'c';
            TextBox.Text += "cos";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            exp += '%';
           TextBox.Text += '%';
        }

        private void button27_Click(object sender, EventArgs e)
        {
            exp += 'e';
            TextBox.Text += 'e';
        }

        private void button31_Click(object sender, EventArgs e)
        {
            exp += 't';
           TextBox.Text += "tan";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            exp += '²';
            TextBox.Text += '²';
        }

        private void button32_Click(object sender, EventArgs e)
        {
            exp += 'q';
            TextBox.Text += '√';
        }

        private void button34_Click(object sender, EventArgs e)
        {
            exp += '^';
           TextBox.Text += '^';
            
        }

        private void button24_Click(object sender, EventArgs e)
        {


            if (TextBox.Text.Length == 0)
            {
                MessageBox.Show("请先输入数据");
                return;
            }
            exp += '¹';
            TextBox.Text +='¹';
            Trans();
            GetValue();

            TextBox.Text += System.Environment.NewLine;
            TextBox.Text += '=';
            TextBox.Text += ans;
            exp = ans.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (TextBox.Text.Length == 0)
            {
                MessageBox.Show("请先输入数据");
                return;
            }

            exp += 'n';
            TextBox.Text += "(取相反数)";
            Trans();
            GetValue();
            TextBox.Text += System.Environment.NewLine;
            TextBox.Text += '=';
            TextBox.Text += ans;
            exp = ans.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {

            if (TextBox.Text.Length == 0)
            {
                MessageBox.Show("请先输入数据");
                return;
            }
            exp += 'j';
            TextBox.Text += "(取绝对值)";
            Trans();
            GetValue();
            TextBox.Text += System.Environment.NewLine;
            TextBox.Text += '=';
            TextBox.Text += ans;
            exp = ans.ToString();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            exp += 'i';
            TextBox.Text += "arcsin";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            exp += 'o';
            TextBox.Text += "arccos";
        }

        private void button38_Click(object sender, EventArgs e)
        {
            exp += 'k';
           TextBox.Text += "arctan";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            exp += 'g';
            TextBox.Text += "log";
        }

        private void button42_Click(object sender, EventArgs e)
        {
            exp += 'l';
            TextBox.Text += "ln";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            exp += '!';
            TextBox.Text += "!";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            exp += 'p';
            TextBox . Text += 'E';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 二进制_CheckedChanged(object sender, EventArgs e)
        {
            point.Enabled = false;
            neg.Enabled = false;
            num0.Enabled = true;
            num1.Enabled = true;
            num2.Enabled = false;
            num3.Enabled = false;
            num4.Enabled = false;
            num5.Enabled = false;
            num6.Enabled = false;
            num7.Enabled = false;
            num8.Enabled = false;
            num9.Enabled = false;
            A10.Enabled = false;
            B11.Enabled = false;
            C12.Enabled = false;
            D13.Enabled = false;
            E14.Enabled = false;
            F15.Enabled = false;
            pi.Enabled = false;
            eee.Enabled = false;
            leftkh.Enabled = false;
            rightkh.Enabled = false;
            equal.Enabled = false;
            add.Enabled = false;
            sub.Enabled = false;
            multiply.Enabled = false;
            divide.Enabled = false;
            mod.Enabled = false;
            sqrt.Enabled = false;
            square.Enabled = false;
            mi.Enabled = false;
            daoshu.Enabled = false;
            abs.Enabled = false;
            jiec.Enabled = false;
            expp.Enabled = false;
            sin.Enabled = false;
            cos.Enabled = false;
            tan.Enabled = false;
            arcsin.Enabled = false;
            arccos.Enabled = false;
            arctan.Enabled = false;
            log.Enabled = false;
            ln.Enabled = false;

            if (TextBox.Text.Length == 0)
            {
                Base = 2;
                             
                return;
            }

            int ans2 = BaseTo10(exp, Base);
            exp = Convert.ToString(ans2, 2).ToUpper();
            TextBox .Text = Convert.ToString(ans2, 2).ToUpper();
            Base = 2;

        }

        private void button35_Click(object sender, EventArgs e)
        {
            exp += 'A';
            TextBox.Text += 'A';
        }

        private void button39_Click(object sender, EventArgs e)
        {
            exp += 'B';
            TextBox.Text += 'B';
        }

        private void button40_Click(object sender, EventArgs e)
        {
            exp += 'C';
            TextBox.Text += 'C';
        }

        private void button43_Click(object sender, EventArgs e)
        {
            exp += 'D';
            TextBox.Text += 'D';
        }

        private void button44_Click(object sender, EventArgs e)
        {
            exp += 'E';
            TextBox.Text += 'E';

        }

        private void button45_Click(object sender, EventArgs e)
        {
            exp += 'F';
            TextBox.Text += 'F';
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            point.Enabled = true;
            neg.Enabled = true;
            num0.Enabled = true;
            num1.Enabled = true;
            num2.Enabled = true;
            num3.Enabled = true;
            num4.Enabled = true;
            num5.Enabled = true;
            num6.Enabled = true;
            num7.Enabled = true;
            num8.Enabled = true;
            num9.Enabled = true;
            A10.Enabled = false;
            B11.Enabled = false;
            C12.Enabled = false;
            D13.Enabled = false;
            E14.Enabled = false;
            F15.Enabled = false;
            pi.Enabled = true;
            eee.Enabled = true;
            leftkh.Enabled = true;
            rightkh.Enabled = true;
            equal.Enabled = true;
            add.Enabled = true;
            sub.Enabled = true;
            multiply.Enabled = true;
            divide.Enabled = true;
            mod.Enabled = true;
            sqrt.Enabled = true;
            square.Enabled = true;
            mi.Enabled = true;
            daoshu.Enabled = true;
            abs.Enabled = true;
            jiec.Enabled = true;
            expp.Enabled = true;
            sin.Enabled = true;
            cos.Enabled = true;
            tan.Enabled = true;
            arcsin.Enabled = true;
            arccos.Enabled = true;
            arctan.Enabled = true;
            log.Enabled = true;
            ln.Enabled = true;

            if (TextBox.Text.Length == 0)
            {
                Base = 10;
                return;
            }
            int ans10 = BaseTo10(exp, Base);
            exp = Convert.ToString(ans10, 10).ToUpper();
            TextBox.Text = Convert.ToString(ans10, 10).ToUpper();
            Base = 10;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


            point.Enabled = false;
            neg.Enabled = false;
            num0.Enabled = true;
            num1.Enabled = true;
            num2.Enabled = true;
            num3.Enabled = true;
            num4.Enabled = true;
            num5.Enabled = true;
            num6.Enabled = true;
            num7.Enabled = true;
            num8.Enabled = false;
            num9.Enabled = false;
            A10.Enabled = false;
            B11.Enabled = false;
            C12.Enabled = false;
            D13.Enabled = false;
            E14.Enabled = false;
            F15.Enabled = false;
            pi.Enabled = false;
            eee.Enabled = false;
            leftkh.Enabled = false;
            rightkh.Enabled = false;
            equal.Enabled = false;
            add.Enabled = false;
            sub.Enabled = false;
            multiply.Enabled = false;
            divide.Enabled = false;
            mod.Enabled = false;
            sqrt.Enabled = false;
            square.Enabled = false;
            mi.Enabled = false;
            daoshu.Enabled = false;
            abs.Enabled = false;
            jiec.Enabled = false;
            expp.Enabled = false;
            sin.Enabled = false;
            cos.Enabled = false;
            tan.Enabled = false;
            arcsin.Enabled = false;
            arccos.Enabled = false;
            arctan.Enabled = false;
            log.Enabled = false;
            ln.Enabled = false;

            if (TextBox.Text.Length == 0)
            {
                Base = 8;
               
                return;
            }
            int ans8 = BaseTo10(exp, Base);

            exp = Convert.ToString(ans8, 8).ToUpper ();
            TextBox.Text = Convert.ToString(ans8, 8).ToUpper();
            Base = 8;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            point.Enabled = false;
            neg.Enabled = false;
            num0.Enabled = true;
            num1.Enabled = true;
            num2.Enabled = true;
            num3.Enabled = true;
            num4.Enabled = true;
            num5.Enabled = true;
            num6.Enabled = true;
            num7.Enabled = true;
            num8.Enabled = true;
            num9.Enabled = true;
            A10.Enabled = true;
            B11.Enabled = true;
            C12.Enabled = true;
            D13.Enabled = true;
            E14.Enabled = true;
            F15.Enabled = true;
            pi.Enabled = false;
            eee.Enabled = false;
            leftkh.Enabled = false;
            rightkh.Enabled = false;
            equal.Enabled = false;
            add.Enabled = false;
            sub.Enabled = false;
            multiply.Enabled = false;
            divide.Enabled = false;
            mod.Enabled = false;
            sqrt.Enabled = false;
            square.Enabled = false;
            mi.Enabled = false;
            daoshu.Enabled = false;
            abs.Enabled = false;
            jiec.Enabled = false;
            expp.Enabled = false;
            sin.Enabled = false;
            cos.Enabled = false;
            tan.Enabled = false;
            arcsin.Enabled = false;
            arccos.Enabled = false;
            arctan.Enabled = false;
            log.Enabled = false;
            ln.Enabled = false;

            if (TextBox.Text.Length == 0)
            {
                Base = 16;
                
                return;
            }
            int ans16 = BaseTo10(exp, Base);
            exp = Convert.ToString(ans16, 16).ToUpper();
            TextBox.Text = Convert.ToString(ans16, 16).ToUpper();
            Base = 16;
        
        }

        private void calculrate_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我会卖萌ฅʕ•̫͡•ʔฅ ฅʕ•̫͡•ʔฅ");
        }
    }
}
