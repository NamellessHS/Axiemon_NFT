# Requirements: Axiemon NFT

**Defined:** 2026-05-05
**Core Value:** Proporcionar uma experiência de RPG tático e imersivo que dá utilidade 3D aos NFTs da rede Ronin.

## v1 Requirements

### Data & API (DATA)
- [ ] **DATA-01**: Sistema de consulta à API GraphQL do Axie Infinity por ID do Axie.
- [ ] **DATA-02**: Parsing de metadados para identificar Partes (Boca, Costas, Chifre, Cauda, Olhos, Orelhas).
- [ ] **DATA-03**: Identificação de Classe e Pureza para cálculo de bônus e Ultimate.
- [ ] **DATA-04**: Cache local de dados para evitar chamadas excessivas à API.

### Visual & Rendering (VISU)
- [ ] **VISU-01**: Sistema de geração procedural de malha/prefab 3D baseada nas partes do Axie.
- [ ] **VISU-02**: Herança de paleta de cores e texturas do Axie original.
- [ ] **VISU-03**: Shader Cel Shaded/Anime aplicado aos Axies e ambiente.
- [ ] **VISU-04**: Animações básicas (Idle, Walk, Attack, Hit, Faint).

### Exploration & World (EXPL)
- [ ] **EXPL-01**: Controlador de personagem 3D (Teclado/Mouse ou Gamepad).
- [ ] **EXPL-02**: Sistema de câmera (Third-person follow).
- [ ] **EXPL-03**: Setup de ambiente de Mundo Aberto com ProBuilder ou Terrain.
- [ ] **EXPL-04**: Sistema de interação com NPCs ou outros jogadores no mundo.

### Battle System (BATT)
- [ ] **BATT-01**: Lógica de turnos (Player vs Player ou Player vs AI) no mundo aberto.
- [ ] **BATT-02**: Implementação de 4 ataques baseados nas partes ativas (Boca, Costas, Chifre, Cauda).
- [ ] **BATT-03**: Implementação de 2 passivas baseadas nas partes (Olhos, Orelhas).
- [ ] **BATT-04**: Mecânica de Ultimate baseada em Classe/Pureza.
- [ ] **BATT-05**: UI de batalha integrada à tela de exploração (sobreposição).

### Network & Multiplayer (NETW)
- [ ] **NETW-01**: Integração com Fish-Net para sincronização de posição no mundo aberto.
- [ ] **NETW-02**: Sincronização de estados de batalha entre jogadores.
- [ ] **NETW-03**: Sistema de instanciamento de batalhas para evitar interferência de terceiros (opcional).

## v2 Requirements

### Economics & NFTs
- **ECON-01**: Integração com Wallet para validação de posse do Axie.
- **ECON-02**: Sistema de recompensas on-chain (SLP/AXS ou novo token).

### Advanced Features
- **ADV-01**: Sistema de itens consumíveis.
- **ADV-02**: Customização cosmética além das partes originais.

## Out of Scope

| Feature | Reason |
|---------|--------|
| Mobile-first | Foco inicial em estabilizar a mecânica tática no Desktop. |
| Breeding | Sistema complexo que foge do escopo de batalha MMORPG. |
| Marketplace interno | Utilizará o marketplace oficial da Sky Mavis inicialmente. |

## Traceability

| Requirement | Phase | Status |
|-------------|-------|--------|
| DATA-01 | Phase 1 | Pending |
| DATA-02 | Phase 1 | Pending |
| DATA-03 | Phase 1 | Pending |
| DATA-04 | Phase 1 | Pending |
| VISU-01 | Phase 2 | Pending |
| VISU-02 | Phase 2 | Pending |
| VISU-03 | Phase 2 | Pending |
| VISU-04 | Phase 2 | Pending |
| EXPL-01 | Phase 3 | Pending |
| EXPL-02 | Phase 3 | Pending |
| EXPL-03 | Phase 3 | Pending |
| EXPL-04 | Phase 3 | Pending |
| BATT-01 | Phase 4 | Pending |
| BATT-02 | Phase 4 | Pending |
| BATT-03 | Phase 4 | Pending |
| BATT-04 | Phase 4 | Pending |
| BATT-05 | Phase 4 | Pending |
| NETW-01 | Phase 5 | Pending |
| NETW-02 | Phase 5 | Pending |
| NETW-03 | Phase 5 | Pending |

**Coverage:**
- v1 requirements: 20 total
- Mapped to phases: 20
- Unmapped: 0 ✓

---
*Requirements defined: 2026-05-05*
*Last updated: 2026-05-05 after initial definition*
