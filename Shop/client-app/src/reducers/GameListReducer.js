const initialState = {
    GameList: [],
    CurrentGame: null
}

const GameListReducer = (state = initialState, action) => {
    switch (action.type) {
        case "GAMES_LOADED":
            return {
                ...state,
                GameList: action.payload
            }
        case "GAME_ADD":
            return {
                ...state,
                GameList: action.payload
            }
        case "GAME_DELETE":
            return {
                ...state,
                GameList: action.payload
            }
        case "GAME_GET":
            return {
                ...state,
                CurrentGame: action.payload
            }
        case "GAME_UPDATE":
            return {
                ...state,
                ContactList: action.payload
            }
        default:
            return state;
    }
}

export default GameListReducer;