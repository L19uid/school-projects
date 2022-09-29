cmake_minimum_required(VERSION 3.23)
project(Pole)

set(CMAKE_CXX_STANDARD 14)

add_executable(Pole main.cpp
                Field.h
                Field.cpp
            )
