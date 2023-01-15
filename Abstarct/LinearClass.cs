using System;
namespace Abstarct
{
	public class LinearClass: SeriesClass
	{
		double firstnumber;
		double difference;
        double number;

        public override double FirstNumber
        {
			get
			{
				return firstnumber;
			}

			set
			{
				firstnumber = value;
			}
			

        }

        public override double SequenceNumber
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }

        }

        public override double Difference
		{

            get
            {
                return difference;
            }

            set
            {
                difference = value;
            }


        }
        public override double GetNNumber()
        {
            double answerNumber = firstnumber + (number - 1) * difference;
            return answerNumber;

        }

        public override double GetSumm()
        {
            double answerSumm = (2*firstnumber + difference * (number-1)) / 2 * number;
            return answerSumm;

        }
    }
}

