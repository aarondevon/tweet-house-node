/* eslint-disable no-console */
import React, { useState, useEffect } from 'react';
import axios from 'axios';
import Tweet from './Tweet';

function TweetSearchPage(props) {
  const [tweetSearchTerm, setTweetSearchTerm] = useState('');
  const [tweets, setTweets] = useState([]);
  const [searchSelector, setSearchSelector] = useState('Keyword');

  const resetTweets = () => {
    setTweets([]);
  };

  const getTweets = async () => {
    const url = searchSelector === 'Keyword' ? `/api/keyword/${tweetSearchTerm}` : `/api/user/${tweetSearchTerm}`;

    const response = await axios.get(url);

    return response;
  };

  const setTweetsToState = (response) => {
    if (searchSelector === 'Keyword' && response.data.statuses !== null) {
      setTweets(response.data.statuses);
    } else if (searchSelector === 'Username' && response.data.length > 0) {
      setTweets(response.data);
    }
  };

  const handelTweetSearchSubmit = async (event) => {
    event.preventDefault();
    resetTweets();
    const response = await getTweets();
    setTweetsToState(response);
  };

  const removeAllWhiteSpaceFromSearchTerm = (searchTerm) => {
    return searchTerm.replace(/\s/g, '');
  };

  const handleSearchSelectorChange = (event) => {
    const trimmedSearch = removeAllWhiteSpaceFromSearchTerm(tweetSearchTerm);
    setTweetSearchTerm(trimmedSearch);
    setSearchSelector(event.target.value);
  };

  const handleSearchChange = (event) => {
    if (searchSelector === 'Username') {
      const trimmedSearch = removeAllWhiteSpaceFromSearchTerm(event.target.value);
      setTweetSearchTerm(trimmedSearch);
      return;
    }
    setTweetSearchTerm(event.target.value);
  };

  const displayTweets = () => {
    return tweets.map((tweet) => {
      return (
        <Tweet
          tweetData={tweet}
          checkForMedia={props.checkForMedia}
          getMedia={props.getMedia}
        />
      );
    });
  };

  useEffect(() => {
  }, [tweets]);

  return (
    <main className="flex center-y column">
      <div id="search-page-container">
        <form
          className="my-2 my-lg-0"
          onSubmit={handelTweetSearchSubmit}
        >
          <div className="row">
            <div className="col-sm-5">
              <div className="form-group">
                <select
                  id="search-select"
                  className="form-control"
                  onChange={handleSearchSelectorChange}
                >
                  <option>Keyword</option>
                  <option>Username</option>
                </select>
              </div>
            </div>
          </div>

          <div className="row">
            <div className="col-sm-9 input-container">
              <div className="form-group">
                <input
                  id="search-input"
                  className="form-control"
                  type="search"
                  placeholder="Search"
                  name="search"
                  aria-label="Search"
                  value={tweetSearchTerm}
                  onChange={handleSearchChange}
                />
              </div>
            </div>
            <div className="col-sm-3 button-container">
              <button
                id="search-button"
                className="btn btn-outline-primary"
                type="submit"
              >
                Search
              </button>
            </div>
          </div>

        </form>
        {console.log(tweets)}
        {tweets.length > 1 ? displayTweets(tweets) : <h3>No tweets to display</h3>}
      </div>

    </main>
  );
}

export default TweetSearchPage;
