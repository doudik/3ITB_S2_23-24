using Composite;

class Program{
    static void Main(string[] args) { 
        Cat cat = new Cat();
        Dog dog = new Dog();
        
        AnimalGang dogGang = new AnimalGang();
        dogGang.AddAnimal(dog);
        AnimalGang catGang = new AnimalGang();
        catGang.AddAnimal(cat);
        catGang.AddAnimal(cat);

        AnimalGang animalGang = new AnimalGang();
        animalGang.AddAnimal(dogGang);
        animalGang.AddAnimal(catGang);

        animalGang.MakeSound();
    }
}