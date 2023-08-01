using N16Home1;
using N16Home1.Spaceship;

Spaceship spaceship = new Spaceship("M515", 1000, 40000, "Vertikal");
spaceship.Display();
spaceship.Speed = 50000;
spaceship.Trojectory = "Vertikal";
spaceship.Display();