using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace search
{
    class Work // 작업 클래스
    {
        public string doc;
        public string keyword;
        public int number = 0;

        public void enter() //입력
        {
            doc = Console.ReadLine(); //첫째줄: 문서이름 입력
            keyword = Console.ReadLine(); //둘째줄: 문서에서 검색하고 싶은 단어 입력
        }

        public void process() //처리
        {
            Regex r = new Regex(" ");
            MatchCollection matches = Regex.Matches(doc, keyword); //문서이름에서 단어를 검색
            number = matches.Count; // number변수에 검색된 단어의 개수 대입
        }

        public void output()
        {
            Console.WriteLine("{0}", number); //개수 출력
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Work work = new Work();
            work.enter(); //입력
            work.process(); //처리
            work.output(); //개수 출력
        }
    }
}

