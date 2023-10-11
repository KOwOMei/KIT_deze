#include <iostream>

int main () {
    setlocale(0,"");
    int a, b, c;
    std::cout << "This is the programm for finding the minimal of 3 ints. How it works? Ne znaiy, just print here any 3 ints: ";
    std::cin >> a >> b >> c;
    int min = a;
    if (min > b) {
        min = b;
    }
    if (min > c) {
        min = c;
    }
    std::cout << "Minimalka is found - " << min;
    return 0;
}