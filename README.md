# Estudo de jogos do estilo Plataforma

## Criação básica do cenário
- Terreno (BoxCollider2D)

## Criação básica do personagem
- [x] Sprites obtidas através do Google Imagens (apenas para fins de estudo)
	- [x] Configurado o sprite como multiple e aplicado o corte automático
- [x] Criação do personagem (empty element)
- [x] Adição do Rigidbody2D (fix rotation Z)
- [x] Adição do Sprite Renderer (adicionado a imagem 0 do sprite)
- [x] Criado a animação Idle
	- [x] Configurado os sprites da animação
- [x] Criado a animação Run
	- [x] Configurado os sprites da animação
- [x] Configurado a variável **speed (float)** para ativar a animação Run
	- [x] Setado a transição da animação para acontecer somente quando **speed** for maior que 0.01 e para parar quando for menor que isso

## Bugs
- [x] Há um delay entre a animação Run > Idle > Run *(corrigido setando o Transition Duration e Offset como 0)*


