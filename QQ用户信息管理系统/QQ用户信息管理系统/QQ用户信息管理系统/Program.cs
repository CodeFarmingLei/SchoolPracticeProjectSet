using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QQ用户信息管理系统
{
    class Program
    {
        static void Main(string[] args)
        {
            //用户输入变量
            string aUname, aPwd;
            //主菜单选择变量
            int xz,xz2;
            //用户信息测试对比用变量
            string bUname = "admin",bPwd = "123456";
            //迷之开关
            bool flag = false;

            Console.WindowWidth = 55;
            Console.WindowHeight = 40;

            Console.Title = "QQ用户信息管理系统 ---- 版本：Beta v1.0";
            
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("请输入用户名：");
                aUname = Console.ReadLine();
                Console.Write("请输入密码：");
                aPwd = Console.ReadLine();
                Console.WriteLine();

                //判断用户输入用户名
                if(aUname==null && aPwd==null)  //当用户名与密码输入为空时执行...
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("输入错误，请重新输入~~ (按回车键继续) \n", ConsoleColor.Red);
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else if (!(aUname == bUname && aPwd == bPwd))  //当用户名与密码输入错误时执行...
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("账号或密码错误,请重试~~ (按回车键继续) \n", ConsoleColor.Red);
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else  //退出循环，执行登陆操作...
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("登陆成功!! (按回车键继续) \n", ConsoleColor.Green);
                    Console.ReadLine();
                    Console.Clear();
                    flag = true;
                }
            } while (flag==false);

            //主页面
            Console.Title = "QQ用户信息管理系统 < 主菜单";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("======欢迎登陆QQ用户信息管理系统======");
            Console.WriteLine("--------请选择操作键--------");
            Console.Write(" 1、显示用户信息 \n 2、更新在线天数 \n");
            Console.Write(" 3、添加用户 \n 4、更新用户等级 \n");
            Console.Write(" 5、删除用户 \n 6、退出 \n");
            Console.WriteLine("======================================");

            Console.Write("请输入编号：");
            xz = int.Parse(Console.ReadLine());

            switch (xz)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("===程序设置集(临时设置)===");
                    Console.WriteLine("1.字体颜色设置");
                    Console.WriteLine("2.背景颜色设置");
                    Console.Write("\n请输入设置编号：");
                    xz2 = int.Parse(Console.ReadLine());

                    switch (xz2)
                    {
                        case 1:
                            Console.WriteLine("1.黑色\t2.白色3.红色\t4.绿色");
                            Console.Write("\n请输入设置编号：");
                            xz2 = int.Parse(Console.ReadLine());

                            if (xz2 == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("设置成功!!");
                            }
                            else if (xz2 == '2')
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("设置成功!!");
                            }
                            else if (xz2 == '3')
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("设置成功!!");
                            }
                            else if (xz2 == '4')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("设置成功!!");
                            }
                            else
                            {
                                Console.Write("输入有误!!退出~~", ConsoleColor.Red);
                            }
                            break;

                        case 2:
                            Console.WriteLine("1.黑色\t2.白色3.红色\t4.绿色");
                            Console.Write("\n请输入设置编号：");
                            xz2 = int.Parse(Console.ReadLine());

                            if (xz2 == '1')
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.WriteLine("设置成功!!");
                            }
                            else if (xz2 == '2')
                            {
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.WriteLine("设置成功!!");
                            }
                            else if (xz2 == '3')
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("设置成功!!");
                            }
                            else if (xz2 == '4')
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.WriteLine("设置成功!!");
                            }
                            else
                            {
                                Console.Write("输入有误!!退出~~", ConsoleColor.Red);
                            }
                            break;
                    }
                break;

                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;
                case 5: break;

                case 6:
                    Console.Title = "QQ用户信息管理系统 < 退出";
                    Console.Clear();
                    Console.WriteLine("程序结束，感谢您的使用*^_^* !!", ConsoleColor.Green);
                    Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
