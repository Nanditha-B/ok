// See https://aka.ms/new-console-template for more information


using Assignment_1_DataSecurity_Encoding1.Models;
using System.Runtime.CompilerServices;


Console.WriteLine("===========Task 1 : User Input===========\n");                //Printing Prompt
Console.Write("Enter your full name : ");                                        //Text to prompt user input
string fullName = Console.ReadLine();                                            //Read user input
Console.Write("Enter number for key : ");                                        //Text to prompt user input
int key = Convert.ToInt32(Console.ReadLine());                                    //Read user input

//Task 2 : Binary Convertor
Console.WriteLine("\n\n===========Task 2 : Binary Convertor===========\n");     //Print in output
BinaryConverter base2 = new BinaryConverter();                                  //Text to prompt user input
string binarydata = base2.String2Binary(fullName);                              //Calling class to perform String to Binary Conversion
base2.Binary2String(binarydata);                                                //Calling class to perform Binary to String Conversion

//Task 3 : HexaDecimal Convertor
Console.WriteLine("\n\n===========Task 3 : Hexadecimal Convertor===========\n");//Print in output
HexadecimalConverter base16 = new HexadecimalConverter();                       //Text to prompt user input
string hexdata = base16.String2Hex(fullName);                                    //Calling class to perform String to Hexa Conversion
base16.Hex2String(hexdata);                                                     //Calling class to perform Hexa to String Conversion

//Task 4 : Base64 Convertor
Console.WriteLine("\n\n==========Task 4 : Base64 Convertor==========\n");
Base64Converter base64 = new Base64Converter();
string Base64Data = base64.StringtoBase64(fullName);
string ReverseBase64 = base64.Base64toString(Base64Data);

// base64.Base64toString(Base64Data)

//Task 5 : Encrypt and Decrypt
Console.WriteLine("\n\n==========Task 5 : Encypt and Decrypt==========\n");
EncryptDecrypt shiftcipher = new EncryptDecrypt();
string encrypted_data = shiftcipher.EncryptMessage(fullName, key);
shiftcipher.DecryptMessage(encrypted_data, key);
