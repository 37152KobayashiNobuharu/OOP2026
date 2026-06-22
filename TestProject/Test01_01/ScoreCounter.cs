namespace Test01_01 {
    public class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }

        //メソッドの概要：
        private static IEnumerable<Student> ReadScore(string filePath) {
            var Score = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines) {
                var items = line.Split(',');//カンマ区切りで分割
                var score = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                Score.Add(score);
            }
            return Score;
        }


        //メソッドの概要：
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var Score in _score) {
                if (dict.ContainsKey(Score.Subject)) {
                    //登録されている場合
                    dict[Score.Subject] += Score.Score;//売上を足しこみ
                } else {
                    //未登録の場合
                    dict[Score.Subject] = Score.Score;//新規に売上を登録
                }
            }
            return dict;
        }
    }
}
