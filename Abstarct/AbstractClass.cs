using System;
namespace Abstarct	
{
	public abstract class SeriesClass
	{
		// возвращает Сумма прогресси n-го числа
		public abstract double GetSumm();

		// возвращает N-ое число
		public abstract double GetNNumber();

		// абстрактное свойтсво для хранение первого задонного числа прогресси 
		public abstract double FirstNumber { get; set; }

		// абстрактное свойтсво для хранение разности прогресси 
		public abstract double Difference { get; set; }

        // абстрактное свойтсво для хранение A(n) S(n)
        public abstract double SequenceNumber { get; set; }
			
    }
}

