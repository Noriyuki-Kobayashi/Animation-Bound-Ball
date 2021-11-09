//Console画面でボールを弾ませるアニメです。
//Consoleコマンドの学習用に作成しました。
//Visual Studio 2022 にアップデート 2021-11-9

using System;
using System.Threading;

namespace Animation_Bound_Ball
{
    
    class Program
    {
        static void Main()
        {

            int speed = 120; //コマ間隔時間をmsec単位で指定します。
            int i = 0;

            Console.WriteLine("何かキーを押すと動きます。");
            Console.ReadKey();

            do
            {

                Console.Clear();
                Console.WriteLine("\n\n\n               (*^▽^)_");
                Console.WriteLine("                       o\n\n");

                Thread.Sleep(speed); //指定した時間だけスレッドを一時停止します。

                Console.Clear();
                Console.WriteLine("\n\n               (*^▽^)/o\n\n\n\n");
                Thread.Sleep(speed); //指定した時間だけスレッドを一時停止します。

                i++;

            }
            while (i <= 10);

            Console.Clear();
            Console.WriteLine("\n\n\n               ( ･＿･)_");
            Console.WriteLine("                       x\n\n");
            Console.ReadKey();

        }
    }
}