#include <SFML/Graphics.hpp>

extern void initGameLogic();
extern void renderUI();

int main()
{
    initGameLogic();

    sf::RenderWindow window(sf::VideoMode(800, 600), "Isometric Hack & Slash Game");
    while (window.isOpen())
    {
        sf::Event event;
        while (window.pollEvent(event))
        {
            if (event.type == sf::Event::Closed)
                window.close();
        }

        window.clear();
        renderUI();
        window.display();
    }
    return 0;
}