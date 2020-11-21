using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace AidsTest.Models
{
   class Questionnaire
    {
        static private Random random = new Random();
        private static int firstPartQuestionsAmount = 18;
        public List<Question> AllStartQuestions { get; set; }

        public Questionnaire()
        {
            AllStartQuestions = GetAllQuestionsForBoth();
        }
        private static List<Question> firstPartQuestions { get; set; } = new List<Question>()
        {
            new Question("Где вы познакомились со своим партнером/партнершей?",
                new ObservableCollection<Answer>(){
                    new Answer("В парке (на улице, в клубе)", 5),
                    new Answer("В интернете", 4),
                    new Answer("На работе", 3)}) ,
            new Question("Часто ли вы проводите время со своими друзьями?",
                new ObservableCollection<Answer>(){
                    new Answer("Иногда, большую часть времени мы проводим вместе", 5),
                    new Answer("Часто, иногда мы устаем друг от друга", 4),
                    new Answer("Мы больше видимся с друзьями, чем друг с другом", 3)}) ,
            new Question("Как вы считаете, супруги должны проводить отпуск вместе?",
                new ObservableCollection<Answer>(){
                    new Answer("Да, это время, когда можно насладиться друг другом", 5),
                    new Answer("Необязательно, можно поехать с друзьями", 4),
                    new Answer("В отпуск лучше отправиться по отдельности", 3)}) ,
            new Question("У вас есть определенные традиции, которых вы придерживаетесь?",
                new ObservableCollection<Answer>(){
                    new Answer("Да, соблюдаем регулярно", 5),
                    new Answer("У нас есть несколько традиций, мы их не всегда соблюдаем", 4),
                    new Answer("Нет, в нашей семье нет никаких традиций", 3)}) ,
            new Question("Вы разрешите своему партнёру/партнерше иметь друзей противоположного пола после свадьбы?",
                new ObservableCollection<Answer>(){
                    new Answer("Почему нет, конечно, пусть будут", 5),
                    new Answer("Пара друзей должны оставаться", 4),
                    new Answer("Никаких друзей противоположного пола не должно быть", 3)}) ,
             new Question("Бывает ли такое, что вы ревнуете свою половинку?",
                new ObservableCollection<Answer>(){
                    new Answer("Нет, я полностью доверяю", 5),
                    new Answer("Да, иногда могу приревновать", 4),
                    new Answer("Ревную всегда", 3)}) ,
             new Question("Счастливо ли живут в браке ваши родители?",
                new ObservableCollection<Answer>(){
                    new Answer("Да, мои родители живут счастливо", 5),
                    new Answer("Всякое бывает, столько лет вместе", 4),
                    new Answer("Мои родители в разводе", 3)}) ,
             new Question("Какую цель вы преследовали, создавая свой союз?",
                new ObservableCollection<Answer>(){
                    new Answer("Любовь, теплота, взаимопонимание, дети", 5),
                    new Answer("Хорошее времяпровождение", 4),
                    new Answer("Достижение каких-либо материальных благ, карьерный рост", 3)}) ,
             new Question("Какие у вас отношения с матерью (если вы мужчина)/отцом (если вы девушка)?",
                new ObservableCollection<Answer>(){
                    new Answer("Теплые дружеские отношения, могу рассказать своей материи/своему отцу все что угодно", 5),
                    new Answer("У нас нормальные отношения, как у родителей с ребенком", 4),
                    new Answer("У меня плохие отношения с отцом/матерью", 3)}) ,
             new Question("Вы любите получать подарки от партнёра/партнерши?",
                new ObservableCollection<Answer>(){
                    new Answer("Конечно, это очень приятно", 5),
                    new Answer("Я люблю больше дарить, чем получать", 4),
                    new Answer("Зачем тратиться на подарки, это лишние расходы", 3)}) ,
             new Question("Ловите ли вы себя на мысли о том, что вам легче рассказать о чем-то просто приятелю, чем любимому человеку?",
                new ObservableCollection<Answer>(){
                    new Answer("Приятель(ница) понимает меня лучше…", 5),
                    new Answer("Нет, о своих делах я говорю только с любимым(ой)", 4),
                    new Answer("Иногда такое и впрямь случается", 3)}) ,
             new Question("Случается ли такое, что, когда с вами разговаривает любимый человек, вы в этот момент думаете о чем-то другом?",
                new ObservableCollection<Answer>(){
                    new Answer("Довольно часто", 5),
                    new Answer("Всегда слушаю его (ее) очень внимательно", 4),
                    new Answer("Если я чувствую, что мои мысли где-то далеко, я пытаюсь сосредоточиться", 3)}) ,
             new Question("Бывает ли такое, что ваш(а) любимый(ая) упорно не хочет с вами поделиться тем, что его (ее) на данный момент тяготит?",
                new ObservableCollection<Answer>(){
                    new Answer("Нет, я всегда в курсе всех его (ее) дел", 5),
                    new Answer("Никогда не обращал(а) на это внимание", 4),
                    new Answer("Да, иногда", 3)}) ,
             new Question("Недоразумения между влюбленными – вещь довольно обычная. Бывает ли у вас такое чувство, что вам необходимо выяснить отношения?",
                new ObservableCollection<Answer>(){
                    new Answer("Иногда мне этого очень хочется", 5),
                    new Answer("Когда это происходит, мы, обычно, ссоримся", 3),
                    new Answer("Таких ситуаций не бывает в наших отношениях", 4)}) ,
             new Question("Когда вы делитесь с любимым человеком своими проблемами, у вас не возникает ощущения, что это его (ее) раздражает?",
                new ObservableCollection<Answer>(){
                    new Answer("Наоборот, он(а) всегда стремится помочь мне", 5),
                    new Answer("Его (ее) не интересуют мои проблемы", 3),
                    new Answer("Не знаю", 4)}) ,
             new Question("Может ли кто-то из вас двоих принять важное для вас обоих решение, не посоветовавшись при этом с другим?",   //16
                new ObservableCollection<Answer>(){
                    new Answer("Случается иногда", 3),
                    new Answer("Все важные дела мы решаем вместе", 5),
                    new Answer("Мы всегда советуемся, но каждый может остаться при своем мнении", 4)}) ,
              new Question("В чем вы больше убеждаетесь, чем ближе становятся ваши отношения?",   //16
                new ObservableCollection<Answer>(){
                    new Answer("У вашего партнера есть масса недостатков, что вас не слишком радует", 3),
                    new Answer("Ваши свидания потеряли былую новизну", 4),
                    new Answer("Ваши симпатии раз от раза только растут", 5)}) ,
               new Question("Какой, по-вашему, должна быть идеальная пара?",
                new ObservableCollection<Answer>(){
                    new Answer("И она, и он самоотверженно заботятся друг о друге", 5),
                    new Answer("Мы должны полностью друг друга понимать", 5),
                    new Answer("Вы должны быть уверены в искренней любви партнера", 5)}) ,
               new Question("Как миритесь после конфликта?",       //18
                new ObservableCollection<Answer>(){
                    new Answer("Просите прощения сразу", 5),
                    new Answer("Спустя некоторое время", 4),
                    new Answer("Никак. Жду первого шага второй половинки!", 3)}) ,
                new Question("Из перечисленного ниже к вам относится следующее:",       //20
                new ObservableCollection<Answer>(){
                    new Answer("Вы хотели бы помочь своему партнеру утвердиться в жизни", 3),
                    new Answer("Вторая половина настолько самостоятельна, что в вашей помощи не слишком нуждается", 4),
                    new Answer("Вы могли бы взять на себя часть дел своего партнера, чтобы оказать ему помощь", 5)}) ,
                 new Question("Иногда бывает так, что один партнер пытается командовать другим. Вы…",       //21
                new ObservableCollection<Answer>(){
                    new Answer("За равноправие", 5),
                    new Answer("Не видите ничего плохого в том, чтобы подчиняться любимому человеку", 4),
                    new Answer("Сами любите командовать", 3)}) ,
                 new Question("Финансовые вопросы в вашем союзе решаются следующим образом:",       //22
                    new ObservableCollection<Answer>(){
                        new Answer("Сами помогаете ему материально", 3),
                        new Answer("Ваш партнер дает вам деньги в долг", 4),
                        new Answer("Вы очень редко просите у него взаймы", 5)}) ,
                 new Question("Вам нравится вместе заниматься повседневными делами",       //23
                    new ObservableCollection<Answer>(){
                        new Answer("Да", 5),
                        new Answer("Иногда", 4),
                        new Answer("Нет", 3)}) ,
                 new Question("У вас есть общее хобби, благодаря которому вы проводите время вместе?",       //24
                    new ObservableCollection<Answer>(){
                        new Answer("Да", 5),
                        new Answer("Есть, но на него редко находится время", 4),
                        new Answer("Нет", 3)}) ,
                  new Question("У вас бывают конфликты из-за разных предпочтений в еде или развлечениях?",       //25
                    new ObservableCollection<Answer>(){
                        new Answer("Да", 3),
                        new Answer("Редко", 4),
                        new Answer("Нет", 5)}) ,
                  new Question("Бывает, что когда вашей половинке весело, вам становится грустно и хочется специально испортить настроение?",       //26
                    new ObservableCollection<Answer>(){
                        new Answer("Да", 3),
                        new Answer("Затрудняюсь ответить", 4),
                        new Answer("Нет", 5)}) ,
                   new Question("Партнер может искренне порадоваться вашим успехам?",       //27
                    new ObservableCollection<Answer>(){
                        new Answer("Да", 5),
                        new Answer("Не всегда", 4),
                        new Answer("Нет", 3)}) ,
                    new Question("Вы быстро договариваетесь, в какой ресторан пойти, или какой фильм посмотреть?",       //28
                    new ObservableCollection<Answer>(){
                        new Answer("Да", 5),
                        new Answer("Когда как", 4),
                        new Answer("Нет", 3)}) ,
                      new Question("Вы согласны, что нужно чаще отдыхать друг от друга, чтобы сохранить хорошие отношения?",       //29
                    new ObservableCollection<Answer>(){
                        new Answer("Да", 5),
                        new Answer("Затрудняюсь ответить", 4),
                        new Answer("Нет", 3)}) ,
                     new Question("Если вы болеете, партнер/партнерша помогает или мешает своим присутствием?",       //30
                    new ObservableCollection<Answer>(){
                        new Answer("Помогает", 5),
                        new Answer("Когда как", 4),
                        new Answer("Мешает", 3)}) ,
                      new Question("Вас устраивает, как на данный момент распределены домашние обязанности?",       //31
                    new ObservableCollection<Answer>(){
                        new Answer("Да", 5),
                        new Answer("Не совсем", 4),
                        new Answer("Нет", 3)}) ,
                        new Question("В вашей паре принято вымещать друг на друге раздражение или плохое настроение после тяжелого трудового дня?",       //32
                    new ObservableCollection<Answer>(){
                        new Answer("Да", 3),
                        new Answer("Иногда так происходит", 4),
                        new Answer("Нет", 5)}) ,


        };

        private List<Question> secondPartQuestions { get; set; } = new List<Question>()
        {
           new Question("Как Вы считаете существует ли риск заражения ВИЧ-инфекцией при сексуальных контактах без использования презерватива?",
                new ObservableCollection<Answer>(){
                    new Answer("Да", 0),
                    new Answer("Нет", 0),
                   }) ,
            new Question("Болели ли Вы в течение последних 10 лет половыми инфекциями (сифилис, гонорея, трихомониаз, хламидиоз)?",
                new ObservableCollection<Answer>(){
                    new Answer("Нет", 0),
                    new Answer("1 раз", 0),
                    new Answer("Более 3 раз", 0)}) ,
             new Question("Были ли в Вашей жизни эпизоды половой связи со случайным партнером/партнершей?",
                new ObservableCollection<Answer>(){
                    new Answer("Да", 0),
                    new Answer("Нет", 0),
                   }) ,
             new Question("Способны ли Вы хранить верность одному половому партнеру/партнерше весь период жизни с ним/с ней?",
                new ObservableCollection<Answer>(){
                    new Answer("Да", 0),
                    new Answer("Нет", 0),
                   }) ,
              new Question("Были ли в Вашей жизни такие сексуальные партнеры/партнерши, от которых возможно было заразиться ВИЧ, cифилисом, гонореей, другими половыми инфекциями?",
                new ObservableCollection<Answer>(){
                    new Answer("Да", 0),
                    new Answer("Нет", 0),
                   }) ,
               new Question("Задумывались ли Вы когда-нибудь о том, что Ваше сексуальное поведение может привести к заражению ВИЧ-инфекцией?",
                new ObservableCollection<Answer>(){
                    new Answer("Да", 0),
                    new Answer("Нет", 0),
                   }),
             new Question("Интимная близость заряжает вас энергией, придает сил и вдохновения?",
                new ObservableCollection<Answer>(){
                    new Answer("Да", 0),
                    new Answer("Нет", 0),
                   }) ,
             new Question("Как часто партнеру хочется близости, а вам нет или наоборот?",
                new ObservableCollection<Answer>(){
                    new Answer("Всегда", 0),
                    new Answer("Иногда", 0),
                    new Answer("Никогда", 0),
                   }) ,
              new Question("У вас совпадает мнение по поводу регулярности и продолжительности полового акта?",
                new ObservableCollection<Answer>(){
                    new Answer("Да", 0),
                    new Answer("Когда как", 0),
                    new Answer("Нет", 0),
                   }) ,
              new Question("Как думаете, вы устраиваете друг друга в сексуальном плане?",
                new ObservableCollection<Answer>(){
                    new Answer("Думаю да", 0),
                    new Answer("Не знаю", 0),
                    new Answer("Думаю нет", 0),
                   }) ,
               new Question("Вам нравится естественный запах тела партнера без парфюмерии?",
                new ObservableCollection<Answer>(){
                    new Answer("Да", 0),
                    new Answer("Почти всегда", 0),
                    new Answer("Нет", 0),
                   }) ,
                new Question("Как часто вы засыпаете и просыпаетесь в одно и то же время?",
                new ObservableCollection<Answer>(){
                    new Answer("Всегда", 0),
                    new Answer("Иногда", 0),
                    new Answer("Никогда", 0),
                   }) ,

        };
        private List<Question> GetFirstPartQuestionsForOnePerson()
        {
            List<Question> questions = new List<Question>();

            do
            {
                int quNumber = random.Next(firstPartQuestions.Count - 1);
                if (!questions.Contains(firstPartQuestions.ElementAt(quNumber)))
                    questions.Add(firstPartQuestions.ElementAt(quNumber));
            }
            while (questions.Count < firstPartQuestionsAmount);

            return questions;
        }

        private List<Question> GetAllQuestionsForOnePerson()
        {
            List<Question> qs = GetFirstPartQuestionsForOnePerson();
            qs.AddRange(secondPartQuestions);
            return qs;
        }

        public List<Question> GetAllQuestionsForBoth()
        {
            List<Question> firstPersonQuestions = GetAllQuestionsForOnePerson();
            List<Question> secondPersonQuestions = GetAllQuestionsForOnePerson();
            List<Question> finalQuestionsList = new List<Question>();

            for (int i = 0; i < firstPersonQuestions.Count; i++)
            {
                finalQuestionsList.Add(firstPersonQuestions[i]);
                finalQuestionsList.Add(secondPersonQuestions[i]);
            }
            return finalQuestionsList;
        }
    }
}
