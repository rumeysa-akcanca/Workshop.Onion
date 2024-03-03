// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Mediator;
using MediatorRealEstate;
using MediatorShipping;
using System.Net.Http.Headers;

Motherboard motherBoard = new();
//Colleague 'ler oluşturuluyor.
CDDriver driver = new(motherBoard);
CPU cpu = new(motherBoard);
DisplayCard displayCard = new(motherBoard);
AudioCard audioCard = new(motherBoard);
//Mediatr'a colleague'ler bildiriliyor.
motherBoard.CDDriver = driver;
motherBoard.CPU = cpu;
motherBoard.AudioCard = audioCard;
motherBoard.DisplayCard = displayCard;

driver.ReadCD();

Shipping shipping = new();
XCompony xCompony = new(shipping);
YCompany yCompany = new(shipping);
ZCompony zCompany = new(shipping);

shipping.XCompony = xCompony;
shipping.YCompany = yCompany;
shipping.ZCompony = zCompany;

xCompony.StartShipping();


Transfer transfer = new();
Receiver receiver = new(transfer);
Realtor realtor = new(transfer);
HomeOwner homeOwner = new(transfer);


transfer.Receiver = receiver;
transfer.Realtor = realtor;
transfer.HomeOwner = homeOwner;

receiver.PayTheHouse(200000);
Console.WriteLine("***********************");
receiver.PayTheHouse(100000);
