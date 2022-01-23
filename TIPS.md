# TIPS
```C#
variables :

	float var = 1.56;

	int var = 20;

	string var = “texte”;

	bool var = true;
	bool var = false;

méthodes :

	void start ()
// au démarage

	update ()
// à chaque frames
	
autres :
	
	Debug.Log(var);
// affiche dans la console
	[SerializeField]
// permet de modifier les variables situés en dessous directement dans unity

état :

	private void Start ()
	private int var;
// variables disponibles seulement dans la fonction, plus sécure

	public  void Start ()
	public int var;
// variables disponibles partout

maths :

	Debug.Log(var * 4);
// multiplie une nombre par un autre

	var *= 4
// multiplie la variable par un nombre
	var += 4
// ajoute un nombre à la variable
	var -= 4
// soustrait un nombre à la variable

	var --;
// soustrait 1
	var ++;
// ajoute 1

condition :


	if(var)
	{
	}
// si la variables est true alors …
	if(!var)
	{
	}
// si la variables est false alors …

	if(var==true)
	{
	}
// si la variables est … alors …
	if(var<= 50)
	{
	}
	else
	{
	}
// si la variable … alors … sinon …
	if(var== 30)
	{
	}
	else if (var<59)
	{
	}
// si la variable … alors … sinon si … , …






	switch (var)
	{
		case 17:
			{
				break;
			}
		default:
			{
				break;
			}
	}
//si la variables est égale à 17 alors ...sinon …
	switch (var)
	{
		case 15:
		case 16:
		case 17:
			{
				break;
			}
		default:
			{
				break;
			}
	}
//si la variables est égale à 16, 15 ou 17 alors ...sinon …

opérateurs :

	if(var== 30 && var2 == 50)
	{
	}
// si var égale à 30 et var2 égale à 50 alors …
		if(var== 30 || var2 == 50)
	{
	}
// si var égale à 30 ou var2 égale à 50 alors …
( || fait avec alt gr + 6 )
	if(var== true ^ var2 == true)
	{
	}
// si var égale à 30 ou var2 égale à 50 alors false
(XOR)

	string strVar=(var) ? « bonjour » : « bonsoir » ;
	Debug.Log(strVar) ;
// si var est true alors bonjours, si var est false alors bonsoir

tableaux :

	int[] var = new int[4]
// création tableau de 4 colonnes
	var[0] = 45;
	var[1] = 22;
	var[2] = 47;
	var[3] = 59;
// assignation des colonnes
( ! commence à 0 )

	Debug.Log(var.Lenght);
// donne la taille du tableau
( ! 3 → 0,1,2)
	 Debug.Log(var[0]
// donne la valeur de la colonne 0

	int[] var = new int[] {1,2,3,4}
	string[] var = new string[] {« a », « b », « c », « d »}
// création tableau et assignation colonnes

tableaux multidimentionnels:

	string[,] var = new string[3,2]
// création tableau de 3 lignes et 2 colonnes
	var[0,0] = « boul »;
	var[0,1] = « bill »;

	var[1,0] = « toto »;
	var[1,1] = « ro »;

	var[2,0] = « bibi »;
	var[2,1] = « bobo »;
// assignation des lignes du tableau

	 Debug.Log(var[indexTab,0] + « et » + var[indexTab,1]);
// donne le mot de la première case et de la deuxième :  boul et  bill
( ! ne peut pas s’afficher dans unity)

boucles conditionnelles :

	for (int i=0; i<100 ; i++)
		{
			Debug.log(i) ;
		}
// indentation variable i + tant que i est plus petit que 100, faire i + 1, dire i
(vérifie avant → s’arrête à 99)
	int i  = 0 ;
	while(i<100)
	{
		i++ ;
		Debug.log(i) ;
	}
// indentation variable i + tant que i est plus petit que 100, faire i + 1, dire i
(ici on ajoute 1 avant d’écrire→ s’arrête à 100)

	break ;
// casse la boucle

	do
	{
		i++ ;
		Debug.log(i) ;
	}
	while (i < 0) :
// faire i + 1, dire i tant que i est plus petit que 0,
(la vérification est faite après → s’arrête à 1)

	int[] monTableau = new int[100] ;
	for(int i=99 ; i > 0 ; i--)
	{
	monTableau[i] = i ;
	}
// remplit le tableau

	foreach(int temp in  monTableau)
	{
		Debug.log(Temp) ;
	}
// écrit le contenu du tableau valeur par valeur

méthodes (fonction) :

	void AfficheScore(string pseudo = « Bill »)
	{
		Debug.log(pseudo) ;
	}
// crée la méthode AfficheScore avec le paramètre «pseudo»

	AfficheScore() ;
// appelle la méthode AfficheScore



	private void Start()
	{
	AfficheScore(« boul », 44) ;
	}
	private void AfficheScore(string pseudo, int score)
	{
		Debug.log(pseudo + score) ;
	}
// «  string pseudo, int score » sont des paramètres, au démarrage, la méthode est appelée et assigne les paramètres par « « boul », 44 »

private void Start()
	{
	AfficheScore(« boul », 44) ;
	}
	private void AfficheScore(string pseudo = « Bill », int score = 3)
	{
		Debug.log(pseudo + score) ;
	}
// «  string pseudo, int score » sont des paramètres, au démarrage la méthode est appelée et assigne les paramètres par « « boul », 44 »

fonction :

	private void Start()
	{
		Debug.Log (Multiply(5, 6)) ;
	}
	int Multiply(int x, int y)
	{
		return x * y ;
	}
```