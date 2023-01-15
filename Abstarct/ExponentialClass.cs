using System;
using System.Data;

namespace Abstarct
{
	public class ExponentialClass: SeriesClass
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
            double answerNumber = firstnumber * Math.Pow(difference, (number - 1));
            return answerNumber;


        }

        public override double GetSumm()
        {
            double answerSumm = (firstnumber * (Math.Pow(difference, number) - 1) 
                )/ (difference - 1);
            return answerSumm;

        }
    }
}

