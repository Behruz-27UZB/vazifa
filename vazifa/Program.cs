using vazifa;

List<User> user = new List<User>()
{
    new User(){
        Id = 1,
        FullName = "Oybek",
        Age = 16,
        CarName = "AUDI"
    },
    new User(){
        Id = 2,
        FullName = "Jamshid",
        Age = 18,
        CarName = "BMW"
    },
    new User(){
        Id = 3,
        FullName = "Behruz",
        Age = 15,
        CarName = "Shewrolet"
    },
    new User(){
        Id = 4,
        FullName = "Dadaxon",
        Age = 15,
        CarName = "Supra"
    },


};

List<Car> car = new List<Car>()
{
  new Car(){
    Id = 1,
    CarName = "AUDI",
    Discription = "AUDI bu hamma mashinaning eng eng zuri"
  },
    new Car(){
    Id = 2,
    CarName = "BMW",
    Discription = "BMW sport uchun muljallangan"
  },
    new Car(){
    Id = 3,
    CarName = "Supra",
    Discription = "Supra bu yaxshi mashina"
  },
    new Car(){
    Id = 1,
    CarName = "Shevrolet",
    Discription = "Shevrolet UZB da kup mashina"
  },

};
for(int i = 0;i < user.Count; i++)
{
    if(i == 3)
    {
        for(int a = 0; a < car.Count; a++)
        {
            Console.WriteLine($"            {car[a]}\n");
        }
    }
    else
    {
        Console.WriteLine($"{user[i]}");
    }

}