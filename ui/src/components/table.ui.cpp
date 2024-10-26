// table.ui.cpp
#include <SFML/Graphics.hpp>
#include <vector>

class TableUI {
public:
    TableUI(int rows, int cols, const sf::Vector2f& cellSize) 
        : rows(rows), cols(cols), cellSize(cellSize) 
    {
        cells.resize(rows * cols, sf::RectangleShape(cellSize));
        for (int i = 0; i < rows; ++i) {
            for (int j = 0; j < cols; ++j) {
                cells[i * cols + j].setPosition(j * cellSize.x, i * cellSize.y);
                cells[i * cols + j].setFillColor(sf::Color::White);
            }
        }
    }

    void draw(sf::RenderWindow& window) {
        for (auto& cell : cells) {
            window.draw(cell);
        }
    }

private:
    int rows, cols;
    sf::Vector2f cellSize;
    std::vector<sf::RectangleShape> cells;
};