import React, { Component } from "react";
import { getAllCards, shuffleCards } from "../apiservices/card-services";
import Card from "./card";

class Cards extends Component {
  state = {
    cardsHolder: []
  };

  componentDidMount = async () => {
    var cardsHolder = await getAllCards();
    this.setState({ cardsHolder });
  };

  shuffle = async () => {
    var cardsHolder = await shuffleCards();
    this.setState({ cardsHolder });
  };

  render() {
    return (
      <div>
        <ul className="cards-holder">
          {this.state.cardsHolder.map((card, i) => (
            <Card key={i} card={card} />
          ))}
        </ul>
        <button
          className="shuffle"
          disabled={this.state.isShuffling}
          onClick={this.shuffle}
        >  Shuffle     
        </button>
      </div>
    );
  }
}

export default Cards;
