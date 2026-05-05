# Axiemon NFT

## What This Is

Um MMORPG 3D online baseado em turnos onde os jogadores utilizam seus Axies da rede Ronin como personagens. O jogo foca em exploração de mundo aberto e batalhas táticas integradas diretamente ao ambiente, com uma estética Cel Shaded/Anime.

## Core Value

Proporcionar uma experiência de RPG tático e imersivo que dá utilidade 3D aos NFTs da rede Ronin, focando em estratégia e progressão.

## Requirements

### Validated

(None yet — ship to validate)

### Active

- [ ] Integração com API GraphQL do Axie Infinity para leitura de metadados.
- [ ] Sistema de renderização 3D com herança de cores/texturas dos Axies originais.
- [ ] Sistema de movimentação e exploração em Mundo Aberto.
- [ ] Sistema de batalha em turnos integrado ao mundo aberto (sem transição de cena).
- [ ] Implementação de 4 ataques ativos baseados em partes do Axie (Boca, Costas, Chifre, Cauda).
- [ ] Implementação de 2 passivas baseadas em partes do Axie (Olhos e Orelhas).
- [ ] Sistema de Ultimate baseado na classe ou pureza do Axie.
- [ ] Infraestrutura de rede multiplayer (Fish-Net).
- [ ] Estilo visual Cel Shaded/Anime via URP.

### Out of Scope

- [ ] Economia Play-to-Earn complexa (Foco inicial na diversão e mecânica).
- [ ] Mobile-first (O foco inicial é Desktop Unity).

## Context

- **Engine**: Unity 6 (URP).
- **Rede**: Ronin Network (Metadata via GraphQL).
- **Público**: Jogadores de Axie Infinity e fãs de MMORPGs táticos.

## Constraints

- **Tech Stack**: Unity C#, URP, Fish-Net.
- **Data Source**: GraphQL Axie API (somente leitura inicial).
- **Design**: Deve respeitar as características visuais dos Axies originais.

## Key Decisions

| Decision | Rationale | Outcome |
|----------|-----------|---------|
| Unity URP | Versatilidade, performance e suporte a Shader Graph para Cel Shading. | — Pending |
| Fish-Net | Solução moderna e performática para multiplayer na Unity. | — Pending |
| Batalha no Mundo | Aumenta a imersão e evita tempos de carregamento/transições chatas. | — Pending |

## Evolution

Este documento evolui conforme o projeto avança.

**Após cada transição de fase:**
1. Requisitos invalidados? → Mover para Out of Scope com motivo.
2. Requisitos validados? → Mover para Validated com referência à fase.
3. Novos requisitos surgiram? → Adicionar em Active.
4. Decisões para logar? → Adicionar em Key Decisions.

---
*Last updated: 2026-05-05 after initialization*
