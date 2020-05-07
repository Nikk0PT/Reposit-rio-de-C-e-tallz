#include <stdio.h>

int main() {
	char str[] = " tmp/texto.txt";
	FILE *fich;
	fich = fopen (str, "w");
	if(!fich)
	printf("Erro na abertura do ficheiro.");
	else
	printf("Ficheiro aberto com sucesso.");
	fclose(fich);
	return 0;
}
