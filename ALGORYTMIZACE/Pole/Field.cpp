#include "Field.h"

void Field::RemoveValue(int pos) {
    for(int i = 0; i<= sizeof(arrayField) / sizeof(arrayField[0]);i++)
    {
        if(pos != i )
            vectorField->push_back(arrayField[i]);
    }
    VecToArray(-1);
}

void Field::AddValue(int pos, int value) {
    std::cout << sizeof(arrayField) / 8 << std::endl;

    for(int i = 0; i<= sizeof(arrayField) / 8;i++)
    {
        std::cout << i << std::endl;
        if(pos == i)
            vectorField->push_back(value);
        std::cout << i << std::endl;
        vectorField->push_back(arrayField[i]);
    }
    VecToArray(1);
}

void Field::VecToArray(int sizeChange)
{
    int* newArray = new int[sizeof(arrayField)/8 + sizeChange];
    std::cout << "VEC2ARR";

    for(int i = 0; i<= sizeof(vectorField) / sizeof(vectorField[0]);i++)
    {
        newArray[i] = vectorField->at(i);
    }

    arrayField = newArray;

    for(int i = 0; i < sizeof(arrayField) / sizeof(arrayField[0]);i++)
    {
        std::cout << arrayField[i];
    }
    std::cout<<std::endl;
}
void Field::GenerateArray()
{
    for(int i = 0; i < 30;i++)
    {
        std::cout << " " << i << " ";

        arrayField[i] = (5);
        std::cout << " " << arrayField[i] << std::endl;
    }
}
int Field::RandomNext(int min,int max)
{
    return rand() % max + min;
}


