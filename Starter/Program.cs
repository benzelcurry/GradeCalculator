// initialize variables - graded assignments 
int examAssignments = 5;
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
int[] studentScores = new int[10];

Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
  string currentStudent = name;
  decimal studentSum = 0;
  string letterGrade = "";
  decimal finalScore;
  int counter = 0;

  if (currentStudent == "Sophia")
    studentScores = sophiaScores;
  else if (currentStudent == "Andrew")
    studentScores = andrewScores;
  else if (currentStudent == "Emma")
    studentScores = emmaScores;
  else if (currentStudent == "Logan")
    studentScores = loganScores;
  else if (currentStudent == "Becky")
    studentScores = beckyScores;
  else if (currentStudent == "Chris")
    studentScores = chrisScores;
  else if (currentStudent == "Eric")
    studentScores = ericScores;
  else if (currentStudent == "Gregor")
    studentScores = gregorScores;
  else
    continue;

  foreach (int score in studentScores)
  {
    counter++;
    if (counter <= 5)
      studentSum += score;
    else
      studentSum += score * (decimal)0.1;
  }

  finalScore = studentSum / examAssignments;

  if (finalScore >= 97)
    letterGrade = "A+";

  else if (finalScore >= 93)
    letterGrade = "A";

  else if (finalScore >= 90)
    letterGrade = "A-";

  else if (finalScore >= 87)
    letterGrade = "B+";

  else if (finalScore >= 83)
    letterGrade = "B";

  else if (finalScore >= 80)
    letterGrade = "B-";

  else if (finalScore >= 77)
    letterGrade = "C+";

  else if (finalScore >= 73)
    letterGrade = "C";

  else if (finalScore >= 70)
    letterGrade = "C-";

  else if (finalScore >= 67)
    letterGrade = "D+";

  else if (finalScore >= 63)
    letterGrade = "D";

  else if (finalScore >= 60)
    letterGrade = "D-";

  Console.WriteLine($"{name}:\t\t" + finalScore + $"\t{letterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
