using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int Choice = 0, Delay = 50;

            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖabcdefghijklmnopqrstuvwxyzåäö ".ToCharArray();
            int[] Places = new int[57];

            for (int i = 0; i < Places.Length; i++)
            {
                Places[i] = i;
            }
            Console.WriteLine("Want to Encrypt(1) or Decrypt?(2) \n");
            Choice = Convert.ToInt32(Console.ReadLine());

            if(Choice == 1)
            {
                Encrypt();
            }
            else
            {
                Decrypt();
            }

            void Encrypt()
            {
                List<int> MessagePlaces;
                List<int> EncryptedMessagePlaces;

                string Message;

                char[] MessageChar;
                char[] EncryptedMessage;
                int EncryptKey;

                MessagePlaces = new List<int>();
                EncryptedMessagePlaces = new List<int>();

                Console.Clear();
                Console.WriteLine("Enter message");

                Message = Console.ReadLine();

                MessageChar = Message.ToCharArray();

                EncryptedMessage = new char[Message.Length];

                Console.WriteLine("\nKey?");
                EncryptKey = Convert.ToInt32(Console.ReadLine());

                //Making Corresponding numbers from the first message
                for(int i = 0; i < MessageChar.Length; i++)
                {
                    char CurrentChar = MessageChar[i];
                    int CorrespondingInt;

                    for(int a = 0; a < alpha.Length; a++)
                    {
                        if(CurrentChar == alpha[a])
                        {
                            CorrespondingInt = a;

                            MessagePlaces.Add(CorrespondingInt);
                            EncryptedMessagePlaces.Add(CorrespondingInt);

                            Console.Write(CorrespondingInt + " ");

                            Thread.Sleep(Delay);
                        }
                    }
                }

                //Making the new places
                Console.WriteLine("\n");
                for (int b = 0; b < MessagePlaces.Count; b++)
                {
                    EncryptedMessagePlaces[b] += EncryptKey;
                    if(EncryptedMessagePlaces[b] > 57)
                    {
                        EncryptedMessagePlaces[b] -= alpha.Length;
                    }
                    Console.Write(EncryptedMessagePlaces[b] + " ");
                    Thread.Sleep(Delay);
                }

                //Making a new string with the new characters correspondig the odd places array
                Console.WriteLine("\n");
                for(int c = 0; c < EncryptedMessagePlaces.Count; c++)
                {
                    char CorrespondingChar;
                    int CurrentInt;

                    CurrentInt = EncryptedMessagePlaces[c];
                    CorrespondingChar = alpha[CurrentInt];

                    EncryptedMessage[c] = CorrespondingChar;

                    Console.Write(EncryptedMessage[c]);
                    Thread.Sleep(Delay);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\nDone!\n\n");

                if (!Directory.Exists("/Logs"));
                    Directory.CreateDirectory("/Logs");

                FileStream ostrm;
                StreamWriter writer;
                TextWriter oldOut = Console.Out;
                try
                {
                    ostrm = new FileStream("./Logs/" + Message + ".txt", FileMode.Create, FileAccess.Write);
                    writer = new StreamWriter(ostrm);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Cannot open Redirect.txt for writing");
                    Console.WriteLine(e.Message);
                    return;
                }

                Console.SetOut(writer);

                //Write Something here
                Console.WriteLine("Enter message");
                Console.WriteLine(Message);
                Console.WriteLine();
                Console.WriteLine("Key?");
                Console.WriteLine(EncryptKey);
                Console.WriteLine();
                Console.WriteLine("Encryption: ");

                for (int i = 0; i < MessagePlaces.Count; i++)
                {
                    Console.Write(MessagePlaces[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();

                for (int i = 0; i < EncryptedMessagePlaces.Count; i++)
                {
                    Console.Write(EncryptedMessagePlaces[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();

                for (int i = 0; i < EncryptedMessagePlaces.Count; i++)
                {
                    Console.Write(EncryptedMessage[i]);
                }
                Console.WriteLine();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Done!");

                Console.WriteLine();
                Console.WriteLine();

                Console.SetOut(oldOut);
                writer.Close();
                ostrm.Close();

                Console.WriteLine("Wrote everything to: ./Logs/" + Message + ".txt");

                Console.WriteLine("Opening " + Message + ".txt");
                System.Diagnostics.Process.Start("notepad.exe", "./Logs/" + Message + ".txt");
            }

            void Decrypt()
            {
                List<int> EncryptedMessagePlaces;
                List<int> MessagePlaces;
                
                string EncryptedMessage;

                char[] MessageChar;
                char[] EncryptedMessageChar;
                int EncryptKey;

                MessagePlaces = new List<int>();
                EncryptedMessagePlaces = new List<int>();

                Console.Clear();
                Console.WriteLine("Enter message");

                EncryptedMessage = Console.ReadLine();
                EncryptedMessageChar = EncryptedMessage.ToCharArray();
                MessageChar = new char[EncryptedMessageChar.Length];

                Console.WriteLine("\nKey?");
                EncryptKey = Convert.ToInt32(Console.ReadLine());

                //Making Corresponding numbers from the first message
                for (int i = 0; i < MessageChar.Length; i++)
                {
                    char CurrentChar = EncryptedMessageChar[i];
                    int CorrespondingInt;

                    for (int a = 0; a < alpha.Length; a++)
                    {
                        if (CurrentChar == alpha[a])
                        {
                            CorrespondingInt = a;

                            MessagePlaces.Add(CorrespondingInt);
                            EncryptedMessagePlaces.Add(CorrespondingInt);

                            Console.Write(CorrespondingInt + " ");

                            Thread.Sleep(Delay);
                        }
                    }
                }

                //Making the new places
                Console.WriteLine("\n");
                for (int b = 0; b < EncryptedMessagePlaces.Count; b++)
                {
                    MessagePlaces[b] -= EncryptKey;
                    if (MessagePlaces[b] < 0)
                    {
                        MessagePlaces[b] += alpha.Length;
                    }
                    Console.Write(MessagePlaces[b] + " ");
                    Thread.Sleep(Delay);
                }

                //Making a new string with the new characters correspondig the odd places array
                Console.WriteLine("\n");
                for (int c = 0; c < EncryptedMessagePlaces.Count; c++)
                {
                    char CorrespondingChar;
                    int CurrentInt;

                    CurrentInt = MessagePlaces[c];
                    CorrespondingChar = alpha[CurrentInt];

                    MessageChar[c] = CorrespondingChar;

                    Console.Write(MessageChar[c]);
                    Thread.Sleep(Delay);
                }

                if (!Directory.Exists("/Logs")) ;
                Directory.CreateDirectory("/Logs");

                FileStream ostrm;
                StreamWriter writer;
                TextWriter oldOut = Console.Out;
                try
                {
                    
                    ostrm = new FileStream("./Logs/" + EncryptedMessage + ".txt", FileMode.Create, FileAccess.Write);
                    writer = new StreamWriter(ostrm);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Cannot open Redirect.txt for writing");
                    Console.WriteLine(e.Message);
                    return;
                }

                Console.SetOut(writer);

                //Write Something here
                Console.WriteLine("Enter message");
                Console.WriteLine(EncryptedMessage);
                Console.WriteLine();
                Console.WriteLine("Key?");
                Console.WriteLine(EncryptKey);
                Console.WriteLine();
                Console.WriteLine("Decryption: ");

                for (int i = 0; i < EncryptedMessagePlaces.Count; i++)
                {
                    Console.Write(EncryptedMessagePlaces[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();

                for (int i = 0; i < MessagePlaces.Count; i++)
                {
                    Console.Write(MessagePlaces[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();

                for (int i = 0; i < MessagePlaces.Count; i++)
                {
                    Console.Write(MessageChar[i]);
                }
                Console.WriteLine();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Done!");

                Console.WriteLine();
                Console.WriteLine();

                Console.SetOut(oldOut);
                writer.Close();
                ostrm.Close();

                Console.WriteLine();
                Console.WriteLine("Wrote everything to: ./Logs/" + EncryptedMessage + ".txt");
                Console.WriteLine("Opening " + EncryptedMessage + ".txt");

                System.Diagnostics.Process.Start("notepad.exe", "./Logs/" + EncryptedMessage + ".txt");
            }

            Console.ReadKey();
        }
    }
}
