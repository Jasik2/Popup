using System;
using System.ComponentModel;
using System.IO;

namespace Popup
{
    internal class mojpies
    {
        public MyDog Dog { get; set; } = new MyDog();

        public mojpies()
        {

        }

        public string ZbierzDane(string imie, string nazwisko, string nazwaPsa, DateTime dataUrodzenia)
        {
            return $"Imię właściciela: {imie}\n" +
                   $"Nazwisko właściciela: {nazwisko}\n" +
                   $"Nazwa psa: {nazwaPsa}\n" +
                   $"Data urodzenia: {dataUrodzenia.ToShortDateString()}\n" +
                   $"Rodowod: {nazwaPsa}\n";
        }

        public void ZapiszDane(string dane)
        {
            File.WriteAllText("dane.txt", dane);
        }


    }
}
