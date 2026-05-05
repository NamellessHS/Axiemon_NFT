# Roadmap: Axiemon NFT

## Overview

O projeto visa criar um MMORPG 3D onde jogadores exploram um mundo aberto com seus Axies (obtidos via Ronin Network) e participam de batalhas táticas por turnos integradas ao ambiente. O desenvolvimento seguirá uma abordagem modular, começando pela integração de dados e visual, passando pela mecânica de exploração e batalha, e finalizando com o multiplayer.

## Phases

- [ ] **Phase 1: Fundação & Integração de Dados** - Conectar à API do Axie e parsear metadados.
- [ ] **Phase 2: Visual & Estética Cel Shaded** - Renderização 3D dos Axies e estilo anime.
- [ ] **Phase 3: Mundo Aberto & Exploração** - Movimentação, câmera e ambiente inicial.
- [ ] **Phase 4: Core de Batalha Tática** - Lógica de turnos e habilidades integradas ao mundo.
- [ ] **Phase 5: Multiplayer & Sincronização** - Integração com Fish-Net para experiência online.

## Phase Details

### Phase 1: Fundação & Integração de Dados
**Goal**: Validar a leitura de dados reais da rede Ronin para uso na Unity.
**Depends on**: Nothing
**Requirements**: DATA-01, DATA-02, DATA-03, DATA-04
**Success Criteria**:
  1. Conexão bem-sucedida com a API GraphQL.
  2. Log no console da Unity mostrando as partes e classe de um Axie ID específico.
  3. Estrutura de dados (ScriptableObjects ou JSON) pronta para o sistema visual.
**Plans**: 2 plans

Plans:
- [ ] 01-01: Setup do cliente GraphQL e classes de dados.
- [ ] 01-02: Sistema de cache e testes de leitura de metadados.

### Phase 2: Visual & Estética Cel Shaded
**Goal**: Transformar os dados em personagens 3D com estilo visual de anime.
**Depends on**: Phase 1
**Requirements**: VISU-01, VISU-02, VISU-03, VISU-04
**Success Criteria**:
  1. Axie 3D gerado na cena com cores e partes corretas.
  2. Estilo Cel Shaded aplicado e visível.
  3. Animação de Idle básica rodando.
**Plans**: 3 plans

### Phase 3: Mundo Aberto & Exploração
**Goal**: Permitir que o jogador controle seu Axie em um ambiente 3D.
**Depends on**: Phase 2
**Requirements**: EXPL-01, EXPL-02, EXPL-03, EXPL-04
**Success Criteria**:
  1. Jogador movimenta o Axie pelo cenário.
  2. Câmera segue o jogador suavemente.
  3. Cenário básico (terreno/piso) funcional.
**Plans**: 2 plans

### Phase 4: Core de Batalha Tática
**Goal**: Implementar o sistema de turnos e habilidades Pokémon-style.
**Depends on**: Phase 3
**Requirements**: BATT-01, BATT-02, BATT-03, BATT-04, BATT-05
**Success Criteria**:
  1. Início de batalha sem mudar de cena.
  2. Menu de ataques funcionando.
  3. Cálculo de dano e efeitos visuais básicos.
**Plans**: 4 plans

### Phase 5: Multiplayer & Sincronização
**Goal**: Transformar a experiência single-player em MMORPG.
**Depends on**: Phase 4
**Requirements**: NETW-01, NETW-02, NETW-03
**Success Criteria**:
  1. Dois jogadores se veem no mesmo mundo.
  2. Movimentação sincronizada.
  3. Início de batalha sincronizado entre os oponentes.
**Plans**: 3 plans

## Progress

| Phase | Plans Complete | Status | Completed |
|-------|----------------|--------|-----------|
| 1. Fundação & Dados | 0/2 | Not started | - |
| 2. Visual & Estética | 0/3 | Not started | - |
| 3. Mundo & Exploração | 0/2 | Not started | - |
| 4. Core de Batalha | 0/4 | Not started | - |
| 5. Multiplayer | 0/3 | Not started | - |

---
*Last updated: 2026-05-05 after initialization*
