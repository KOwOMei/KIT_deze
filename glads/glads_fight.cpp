#include <iostream>
#include <random>
using std::rand;
using std::cout;
using std::endl;
using std::cin;

class Gladiator {
private:
    int hp = 100;
    int min_dmg = 1;
    int max_dmg = 100;
    int armor = 0;

public:
    Gladiator(int h, int min_d, int max_d, int a) 
    {
        hp = h;
        min_dmg = min_d;
        max_dmg = max_d;
        armor = a;
    }

    void checkout(Gladiator g1, Gladiator g2) {
        if (g1.hp < 0 && g2.hp > 0) {
            cout << "The second Gladiator wins the fight!" << endl;
        }
        else if (g1.hp > 0 && g2.hp < 0) {
            cout << "The first Gladiator wins the fight!" << endl;
        }
        else if (g1.hp < 0 && g2.hp < 0) {
            cout << "Wow, that's a tie... They killed eachother..." << endl;
        }
    }

    void hit_player(Gladiator Glad) {
        while (hp > 0 && Glad.hp > 0) {
            int g1_dmg, g2_dmg;
            g1_dmg = min_dmg + (rand() % max_dmg);
            g2_dmg = Glad.min_dmg + (rand() % Glad.max_dmg);
            hp = hp - (g2_dmg - armor * 2);
            Glad.hp = Glad.hp - (g1_dmg - Glad.armor * 2);
            cout << "Gladiator 1 took " << g2_dmg - armor * 2 << ". HP left: " << hp << endl;
            cout << "Gladiator 2 took " << g1_dmg - Glad.armor * 2 << ". HP left: " << Glad.hp << endl;
        }  
        checkout(*this,Glad);
    };

};

int main() {
    Gladiator Glad1(100, 15, 25, 2);
    Gladiator Glad2(80, 5, 30, 5);
    int ready;

    Glad1.hit_player(Glad2);

    cout << "Are u want to repeat? ";
    cin >> ready;
    if (ready == 1) {
        main();
    }
    return 0;
}