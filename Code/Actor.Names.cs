public abstract partial class Actor
{
	public static readonly string[] NeutralNames = new string[]
	{
		"Adrian", "Alex", "Alexis", "Angel", "Ariel", "Ashton", "Aspen", "Avery",
		"Bailey", "Bellamy", "Billie", "Blaine", "Blake", "Bobby", "Bowie", "Brooklyn",
		"Cameron", "Campbell", "Carson", "Casey", "Charlie", "Chris", "Corey", "Dakota",
		"Dallas", "Dani", "Danny", "Darian", "Devin", "Drew", "Dylan", "Eden",
		"Elliot", "Ellis", "Emerson", "Emery", "Ezra", "Finley", "Frankie", "Gray",
		"Hadley", "Harley", "Harper", "Hayden", "Hunter", "Indigo", "Jackie", "Jamie",
		"Jayden", "Jesse", "Jordan", "Jude", "Kai", "Karter", "Kendall", "Kennedy",
		"Kyle", "Landry", "Lennon", "Logan", "London", "Luca", "Mackenzie", "Maddox",
		"Marley", "Micah", "Morgan", "Oakley", "Parker", "Payton", "Phoenix", "Quinn",
		"Rae", "Rayan", "Reese", "Remy", "Riley", "River", "Robin", "Rory",
		"Rowan", "Royal", "Ryan", "Ryder", "Sage", "Salem", "Sawyer", "Scout",
		"Shawn", "Skylar", "Spencer", "Stevie", "Tate", "Taylor", "Tegan", "Toby",
		"Trinity", "Tyler", "Winter", "Wren"
	};

	public static readonly string[] MaleNames = new string[]
	{
		"James",   "John",    "Robert",  "Michael", "William",  "David",   "Richard", "Joseph",
		"Thomas",  "Charles", "Christopher", "Daniel",  "Matthew","Anthony","Mark",    "Donald",
		"Steven",  "Paul",    "Andrew",  "Joshua",  "Kenneth",  "Kevin",   "Brian",   "George",
		"Timothy", "Ronald",  "Edward",  "Jason",   "Jeffrey",  "Ryan",    "Jacob",   "Gary",
		"Nicholas", "Eric",    "Jonathan", "Stephen", "Larry",    "Justin",  "Scott",   "Brandon",
		"Benjamin", "Samuel",  "Gregory", "Frank",   "Alexander","Raymond", "Patrick", "Jack",
		"Dennis",  "Jerry",   "Tyler",   "Aaron",   "Jose",     "Adam",    "Henry",   "Nathan",
		"Douglas", "Zachary", "Peter",   "Kyle",    "Walter",   "Ethan",   "Jeremy",  "Harold",
		"Keith",   "Christian","Roger",  "Noah",    "Gerald",   "Carl",    "Terry",   "Sean",
		"Austin",  "Arthur",  "Lawrence","Jesse",   "Dylan",    "Bryan",   "Joe",     "Jordan",
		"Billy",   "Bruce",   "Albert",  "Willie",  "Gabriel",  "Logan",   "Alan",    "Juan",
		"Wayne",   "Roy",     "Ralph",   "Randy",   "Eugene",   "Vincent", "Russell", "Elijah",
		"Kai",     "Zion",    "Wesley",  "Everett"
	};

	public static readonly string[] FemaleNames = new string[]
	{
		"Mary", "Patricia", "Linda", "Barbara", "Elizabeth", "Jennifer", "Maria", "Susan", "Margaret", "Dorothy",
		"Lisa", "Nancy", "Karen", "Betty", "Helen", "Sandra", "Donna", "Carol", "Ruth", "Sharon",
		"Michelle", "Laura", "Sarah", "Kimberly", "Deborah", "Jessica", "Shirley", "Cynthia", "Angela", "Melissa",
		"Brenda", "Amy", "Anna", "Rebecca", "Virginia", "Kathleen", "Pamela", "Martha", "Debra", "Amanda",
		"Stephanie", "Carolyn", "Christine", "Marie", "Janet", "Catherine", "Frances", "Ann", "Joyce", "Diane",
		"Alice", "Julie", "Heather", "Teresa", "Doris", "Gloria", "Evelyn", "Jean", "Cheryl", "Mildred",
		"Katherine", "Joan", "Ashley", "Judith", "Rose", "Janice", "Kelly", "Nicole", "Judy", "Christina",
		"Kathy", "Theresa", "Beverly", "Denise", "Tammy", "Irene", "Jane", "Lori", "Rachel", "Marilyn",
		"Andrea", "Kathryn", "Louise", "Sara", "Jacqueline", "Wanda", "Bonnie", "Julia", "Ruby", "Lois",
		"Tina", "Phyllis", "Norma", "Paula", "Diana", "Annie", "Lillian", "Emily", "Megan", "Hannah"
	};

	public static readonly string[] LastNames = new string[]
	{
		"Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis",
		"Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzales", "Wilson", "Anderson", "Thomas",
		"Taylor", "Moore", "Jackson", "Martin", "Lee", "Perez", "Thompson", "White",
		"Harris", "Sanchez", "Clark", "Ramirez", "Lewis", "Robinson", "Walker", "Young",
		"Allen", "King", "Wright", "Scott", "Torres", "Nguyen", "Hill", "Flores",
		"Green", "Adams", "Nelson", "Baker", "Hall", "Rivera", "Campbell", "Mitchell",
		"Carter", "Roberts", "Gomez", "Phillips", "Evans", "Turner", "Diaz", "Parker",
		"Cruz", "Edwards", "Collins", "Reyes", "Stewart", "Morris", "Morales", "Murphy",
		"Cook", "Rogers", "Gutierrez", "Ortiz", "Morgan", "Cooper", "Peterson", "Bailey",
		"Reed", "Kelly", "Howard", "Ramos", "Kim", "Cox", "Ward", "Richardson",
		"Watson", "Brooks", "Chavez", "Wood", "James", "Bennett", "Gray", "Mendoza",
		"Ruiz", "Hughes", "Price", "Alvarez", "Castillo", "Sanders", "Patel", "Myers",
		"Long", "Ross", "Foster", "Jimenez"
	};

	/// <summary>
	/// Generate a random name based on gender
	/// </summary>
	/// <returns>First Name, Last Name</returns>
	public static (string, string) RandomName( Gender gender = Gender.Undefined )
	{
		var randomFirstName = gender switch
		{
			Gender.Male => Game.Random.FromArray( MaleNames ),
			Gender.Female => Game.Random.FromArray( FemaleNames ),
			_ => Game.Random.FromArray( NeutralNames )
		};

		var randomLastName = Game.Random.FromArray( LastNames );

		return (randomFirstName, randomLastName);
	}
}
