#include <iostream>
#include <vector>

class Field
        {
        public:
            void AddValue(int pos, int value);
            void RemoveValue(int pos);
            void VecToArray(int sizeChange);
            void GenerateArray();
        private:
            int size;
            std::vector<int> *vectorField;
            int *arrayField;
            int RandomNext(int min,int max);
};
