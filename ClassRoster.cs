using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_11
{
    internal class ClassRoster : IEnumerable
    {
        List<Student> _classList;

        public ClassRoster()
        {
            _classList = new List<Student>();
        }

        internal List<Student> ClassList { get => _classList; }

        public void AddStudent(Student student)
        {
            _classList.Add(student);
        }

        public IEnumerator GetEnumerator()
        {
            return new ClassRosterEnumerator(ref _classList);
        }

        //In order to work with GetEnumerator, you need to create class that inherits from IEnumerator
        //Create an internal class

        private class ClassRosterEnumerator : IEnumerator
        {
            //Field to keep track of index
            int index = -1;
            List<Student> students;

            //Make sure to take a list of your type, and put REF before it
            public ClassRosterEnumerator(ref List<Student> studentList)
            {
                students = studentList;
            }
            //Return the current item in the list at the index
            public object Current => students[index];

            public bool MoveNext()
            {
                //Increase the index
                index++;

                //if it is past last item on list, return false, else return true
                if(index >= students.Count)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            //Sets index back to -1
            public void Reset()
            {
                index = -1;
            }
        }
    }

    
}
