using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("������� ���� ���:");
            string name = Console.ReadLine();
            Console.WriteLine($"������ {name}");
            Console.ReadKey();

            int x = 45; // ��������, ������� ���� ����������� - � �������� ����� 101101
            int key = 102; //����� ��� ����� ���� - � �������� ����� 1100110
            int encrypt = x ^ key; //����������� ����� ����� 1001011 ��� 75
            Console.WriteLine("������������� �����: " + encrypt);

            int decrypt = encrypt ^ key; // ����������� ����� �������� ����� 45
            Console.WriteLine("�������������� �����: " + decrypt);

            Console.ReadKey();
        }
    }
}
