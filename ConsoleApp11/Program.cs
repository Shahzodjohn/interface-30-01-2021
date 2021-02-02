using System;

namespace ConsoleApp11
{
    interface Iplayable
    {
        void Play();
        void Pause();
        void Stop();

    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player : Iplayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }
        public void Pause()
        {
            Console.WriteLine("Pause");
        }
        public void Record()
        {
            Console.WriteLine("Record");
        }
        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Iplayable iplay = new Player();
            IRecodable irec = new Player();
            iplay.Play();
            iplay.Pause();
            iplay.Stop();
            irec.Pause();
            irec.Record();
            irec.Stop();




        }
    }
}
