/* eslint-disable max-len */
import React from 'react';

function Home() {
  return (
    <main>
      <div className="jumbotron">
        <div className="row">
          <div id="hero-image-container" className="col-sm-12 col-md-6">
            <img id="hero-img" className="img-fluid rounded" src="./images/twitter02.jpg" alt="Man viewing twitter" />
          </div>
          <div className="col-sm-12 col-md-6">
            <h1 className="display-4">Welcome!</h1>
            <p className="lead">
              Tweet House uses the Twitter API, React, and C#. C#
              handles the data from the Twitter API and React interacts via the API created
              with C#. The app allows the user to generate a random tweet from my favorite
              Twitter users. Twitter Showcase also allows the user to search for a Twitter
              user and display some of the most recent tweets by that user, or the user can
              search for specific content and have up to 25 of the most recent tweets display that
              contain that content.
            </p>
          </div>
        </div>

        <hr className="my-4" />
        <p>
          Search for the most recent tweets of your favorite Twitter user, or checkout a random tweet from one of mine.
        </p>
      </div>
    </main>
  );
}

export default Home;
