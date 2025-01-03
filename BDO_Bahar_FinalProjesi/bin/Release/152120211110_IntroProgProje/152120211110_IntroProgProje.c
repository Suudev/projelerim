#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#define BOARD_SIZE 10
#define SHIP_COUNT 3

// Oyun tablosunu oluþturan fonksiyon
void initializeBoard(char board[BOARD_SIZE][BOARD_SIZE]) {
    int i, j;
    for (i = 0; i < BOARD_SIZE; i++) {
        for (j = 0; j < BOARD_SIZE; j++) {
            board[i][j] = '~';
        }
    }
}
// Oyun tahtasýný gemilerle beraber ekrana yazdýran fonksiyon
void printBoard(char board[BOARD_SIZE][BOARD_SIZE]) {
    int i, j;
    for (i = 0; i < BOARD_SIZE; i++) {
        for (j = 0; j < BOARD_SIZE; j++) {
            printf("%c ", board[i][j]);
        }
        printf("\n");
    }
}
// Oyun tablosunu gemisiz ekrana yazdýran fonksiyon
void printHiddenBoard(char board[BOARD_SIZE][BOARD_SIZE]) {
    int i, j;
    for (i = 0; i < BOARD_SIZE; i++) {
        for (j = 0; j < BOARD_SIZE; j++) {
            if (board[i][j] == 'A' || board[i][j] == 'B' || board[i][j] == 'C') {
                printf("~ ");
            } else {
                printf("%c ", board[i][j]);
            }
        }
        printf("\n");
    }
}

// Hamlenin geçerli olup olmadýðýný kontrol eden fonksiyon
int isValidMove(char board[BOARD_SIZE][BOARD_SIZE], int row, int col) {
    return (row >= 0 && row < BOARD_SIZE && col >= 0 && col < BOARD_SIZE && (board[row][col] == '~' || board[row][col] == 'A' || board[row][col] == 'B' || board[row][col] == 'C'));
}

// Geminin vurulup vurulmadýðýný kontrol eden fonksiyon
int isShipHit(char board[BOARD_SIZE][BOARD_SIZE], int row, int col) {
    return (board[row][col] != '~');
}

// Gemileri oyun tablosuna rastgele yerleþtiren fonksiyon
void placeShips(char board[BOARD_SIZE][BOARD_SIZE]) {
    int i;
    for (i = 0; i < SHIP_COUNT; i++) {
        int row, col;
        do {
            row = rand() % BOARD_SIZE;
            col = rand() % BOARD_SIZE;
        } while (!isValidMove(board, row, col));

        char shipSymbol = 'A' + i;

        board[row][col] = shipSymbol;
    }
}

int main() {
    char player1RealBoard[BOARD_SIZE][BOARD_SIZE];
    char player2RealBoard[BOARD_SIZE][BOARD_SIZE];

    char player1HiddenBoard[BOARD_SIZE][BOARD_SIZE];
    char player2HiddenBoard[BOARD_SIZE][BOARD_SIZE];

    

    initializeBoard(player1RealBoard);
    initializeBoard(player2RealBoard);
    initializeBoard(player1HiddenBoard);
    initializeBoard(player2HiddenBoard);
    
    placeShips(player1RealBoard);
    placeShips(player2RealBoard);
    
    printf("Player 1's board with ships:\n");
    printBoard(player1RealBoard);

    printf("Player 2's board with ships:\n");
    printBoard(player2RealBoard);


    int player1Moves = 0;
    int player2Moves = 0;

    while (1) {
        int i, j;

        // Oyuncu 1'in hamlesi
        printf("Player 1's turn:\n");
        printf("Enter row and column (e.g., 1 2): ");
        int row, col;
        scanf("%d %d", &row, &col);

        if (!isValidMove(player2HiddenBoard, row, col)) {
            printf("Invalid move! Try again.\n");
            continue;
        }

        if (isShipHit(player2RealBoard, row, col)) {
            printf("Hit!\n");
            player2HiddenBoard[row][col] = 'X';
        } else {
            printf("Miss!\n");
            player2HiddenBoard[row][col] = 'O';
        }

        player1Moves++;
        printHiddenBoard(player2HiddenBoard);

        int player2ShipsRemaining = 0;

        for (i = 0; i < BOARD_SIZE; i++) {
            for (j = 0; j < BOARD_SIZE; j++) {
                if (player2RealBoard[i][j] != '~' && player2RealBoard[i][j] != 'X' && player2RealBoard[i][j] != 'O') {
                    player2ShipsRemaining++;
                }
            }
        }

        if (player2ShipsRemaining == 0) {
            printf("Player 1 wins in %d moves!\n", player1Moves);
            break;
        }

        // Oyuncu 2'nin hamlesi
        printf("Player 2's turn:\n");
        printf("Enter row and column (e.g., 1 2): ");
        scanf("%d %d", &row, &col);

        if (!isValidMove(player1HiddenBoard, row, col)) {
            printf("Invalid move! Try again.\n");
            continue;
        }

        if (isShipHit(player1RealBoard, row, col)) {
            printf("Hit!\n");
            player1HiddenBoard[row][col] = 'X';
        } else {
            printf("Miss!\n");
            player1HiddenBoard[row][col] = 'O';
        }

        player2Moves++;
        printHiddenBoard(player1HiddenBoard);

        int player1ShipsRemaining = 0;

        for (i = 0; i < BOARD_SIZE; i++) {
            for (j = 0; j < BOARD_SIZE; j++) {
                if (player1RealBoard[i][j] != '~' && player1RealBoard[i][j] != 'X' && player1RealBoard[i][j] != 'O') {
                    player1ShipsRemaining++;
                }
            }
        }

        if (player1ShipsRemaining == 0) {
            printf("Player 2 wins in %d moves!\n", player2Moves);
            break;
        }
    }

    return 0;
}

