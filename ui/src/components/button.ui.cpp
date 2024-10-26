// button.ui.cpp
#include <SFML/Graphics.hpp>

class ButtonUI {
public:
    ButtonUI(const std::string& text, const sf::Vector2f& position, const sf::Vector2f& size) {
        button.setSize(size);
        button.setPosition(position);
        button.setFillColor(sf::Color::Blue);

        font.loadFromFile("path/to/font.ttf"); // Make sure to provide a path
        buttonText.setFont(font);
        buttonText.setString(text);
        buttonText.setCharacterSize(20);
        buttonText.setFillColor(sf::Color::White);
        buttonText.setPosition(
            position.x + (size.x - buttonText.getGlobalBounds().width) / 2,
            position.y + (size.y - buttonText.getGlobalBounds().height) / 2
        );
    }

    void draw(sf::RenderWindow& window) {
        window.draw(button);
        window.draw(buttonText);
    }

    bool isClicked(const sf::Vector2i& mousePos) const {
        return button.getGlobalBounds().contains(static_cast<sf::Vector2f>(mousePos));
    }

private:
    sf::RectangleShape button;
    sf::Text buttonText;
    sf::Font font;
};