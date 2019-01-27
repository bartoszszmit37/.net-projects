using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzewodnikKalkulacyjny
{
    public class CalculationInTextBox
    {
        private AbsoluteValueCalculationForm _asbValueCF;
        private List<Char> _strList = new List<Char>();
        private String _strFromTextBox;
        private String _str;
        char[] _charsTab = new char[5];
        int[] _numbersTab = new int[10];
        int[] _resultsTab = new int[10];
        //List<char> _counterList = new List<char>();
        int _result=0;
        public CalculationInTextBox(AbsoluteValueCalculationForm _asbValueCF)
        {
            this._asbValueCF = _asbValueCF;
            _strList.Add('1');
            //_counterList.Add('-');
        }
        public int AbsDoing(int _v)
        {
            if (_v >= 0)
            {
                return _v;
            }
            else if (_v < 0)
            {
                _v = -_v;
            }
            return _v;
        }
        public int DoingMathOperationInString(String str)
        {
            var _valueToAbsSS =  _asbValueCF.ValueToAbsTxb.SelectionStart;
            string[] num = Regex.Split(str, @"\-|\+|\*|\/").Where(s => !String.IsNullOrEmpty(s)).ToArray();
            string[] op = Regex.Split(str, @"\d{1,3}").Where(s => !String.IsNullOrEmpty(s)).ToArray();
            int numCtr = 0;
            int lastVal = 0;
            String lastOp = "";
            foreach (String m in num)
            {
                numCtr++;
                if (numCtr == 1)
                {
                    //lastVal = double.Parse(m);
                    lastVal = int.Parse(m);
                }
                else
                {
                    if (!String.IsNullOrEmpty(lastOp))
                    {
                        switch (lastOp)
                        {
                            case "+":
                                lastVal = lastVal + int.Parse(m);

                                break;
                            case "-":
                                lastVal = lastVal - int.Parse(m);

                                break;
                            case "*":
                                lastVal = lastVal * int.Parse(m);

                                break;
                            case "/":
                                lastVal = lastVal / int.Parse(m);

                                break;
                        }
                    }
                }
                int opCtr = 0;
                foreach (String o in op)
                {
                    opCtr++;
                    if (opCtr == numCtr)
                    {
                        lastOp = o;
                        break;
                    }
                }
            }
            
            /*str = _asbValueCF.ValueToAbsTxb.Text;

            _strList = str.ToList<Char>();
            NumberChecker._addingResult = 0;
            int n;


            for (int i = 0; i < _strList.Count; i++)
            {
                NumberChecker.isNumber = int.TryParse(_strList[i].ToString(), out n);

                if (NumberChecker.isNumber == true)
                {
                    _numbersTab[i] = Convert.ToInt32(_strList[i].ToString());
                    _resultsTab[i] += _numbersTab[i];
                     NumberChecker._addingResult += _resultsTab[i];
                }
            }
            for (int i = 0; i < _strList.Count; i++)
            {
                if (_strList[i] == '+')
                {
                    --i;
                    _resultsTab[i] += _numbersTab[i++];
                    NumberChecker._addingResult += _resultsTab[i];
                }
            }
               
            _str = Convert.ToString(NumberChecker._addingResult);*/
            return lastVal;
        }
        
        /*public String SubtrachendNumbersInString(String str)
        {
            var _valueToAbsSS = _asbValueCF.ValueToAbsTxb.SelectionStart;

            str = _asbValueCF.ValueToAbsTxb.Text;

            _strList = str.ToList<Char>();
            NumberChecker._addingResult = 0;
            int n;


            for (int i = 0; i < _strList.Count; i++)
            {
                NumberChecker.isNumber = int.TryParse(_strList[i].ToString(), out n);

                if (NumberChecker.isNumber == true)
                {
                    _numbersTab[i] = Convert.ToInt32(_strList[i].ToString());
                    _resultsTab[i]+= _numbersTab[i];
                     NumberChecker._addingResult += _resultsTab[i];
                    //_strList.Add(_strList[i]);


                    //AmountElements._amountElements = 1;
                }



                if (NumberChecker.isNumber == false)
                {

                    if (_strList[i] == '+')
                    {
                        --i;
                        _resultsTab[i] += _numbersTab[i];
                         NumberChecker._addingResult += _resultsTab[i];
                    }

                }

                AmountElements._amountElements++;


                if (NumberChecker.isNumber == false && i==1)
                 {


                 _strList.Add(_strList[i]);
                NumberChecker._addingResult = NumberChecker._firstValue + NumberChecker._secandValue;

                  }
               * if (NumberChecker.isNumber == true && i==2)
                 {
                     NumberChecker._secandValue = Convert.ToInt32(_strList[i].ToString());
                     //_strList.Add(_strList[i]);
                 }
                AmountElements._amountElements++;


            }
            
           NumberChecker._addingResult = NumberChecker._firstValue + NumberChecker._secandValue;
           _str = Convert.ToString(NumberChecker._addingResult);
            return _str;
        }*/
    }
}
