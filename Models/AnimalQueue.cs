using System.Collections.Generic;

namespace AnimalShelterConsoleApp.Models
{
    public class AnimalQueue
    {
        LinkedList<Dog> dogs = new LinkedList<Dog>();
        LinkedList<Cat> cats = new LinkedList<Cat>();
        private int Order = 0;

        #region snippet_Enqueue

        /// <summary>
        /// Enqueues a new animal
        /// </summary>
        /// <param name="animal">Animal object class (Dog or Cat)</param>
        public void Enqueue(Animal animal)
        {
            animal.SetOrder(Order);
            Order++;

            if (animal is Dog) dogs.AddLast((Dog)animal);
            else if (animal is Cat) cats.AddLast((Cat)animal);
        }

        #endregion

        #region snippet_Dequeue

        /// <summary>
        /// Dequeues a dog or cat
        /// </summary>
        /// <returns>Animal object class</returns>
        public Animal DequeueAny()
        {
            if (dogs.Count == 0) return DequeueCats();
            else if (cats.Count == 0) return DequeueDogs();

            var dog = dogs.First.Value;
            var cat = cats.First.Value;

            if (dog.IsOlderThan(cat)) return DequeueDogs();

            return DequeueCats();
        }

        #endregion

        #region snippet_DequeueDog

        /// <summary>
        /// Dequeues the first dog in the linked list
        /// </summary>
        /// <returns>Dog object class</returns>
        public Dog DequeueDogs() => dogs.First.Value;

        #endregion

        #region snippet_DequeueCat

        /// <summary>
        /// Dequeues the first cat in the linked list
        /// </summary>
        /// <returns>Cat object class</returns>
        public Cat DequeueCats() => cats.First.Value;

        #endregion
    }
}