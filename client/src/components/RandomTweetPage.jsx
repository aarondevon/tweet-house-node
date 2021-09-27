/* eslint-disable react-hooks/exhaustive-deps */
/* eslint-disable react/prop-types */
/* eslint-disable arrow-body-style */
import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { Button, Modal } from 'react-bootstrap';
import UserCard from './UserCard';
import Tweet from './Tweet';

function RandomTweetPage(props) {
  const [screenNames] = useState(['npmjs', 'freeCodeCamp', 'ClassicalMPR', 'BBCScienceNews', 'NASA']);
  const [userProfileData, setUserProfileData] = useState([]);
  const [showModal, setShowModal] = useState(false);
  const [randomTweet, setRandomTweet] = useState([]);

  const getUserProfileData = async (screenName) => {
    const response = await axios.get(`/api/twitter-user/${screenName}`);
    return response.data;
  };

  const setUserProfileDataToState = async () => {
    const profileData = screenNames.map((screenName) => {
      return getUserProfileData(screenName);
    });
    setUserProfileData(await Promise.all(profileData));
  };

  const handleClose = () => setShowModal(false);

  const handleShow = () => setShowModal(true);

  const getRandomTweetBasedOnScreenName = async (screenName) => {
    const response = await axios.get(`/api/random-tweet/${screenName}`);
    return response.data;
  };

  const handleRandomTweetOnClick = async (screenName) => {
    const tweetData = await getRandomTweetBasedOnScreenName(screenName);
    setRandomTweet(tweetData);
    handleShow();
  };

  const displayUsers = () => {
    return userProfileData.map((userData) => {
      return (
        <UserCard
          userData={userData}
          getRandomTweet={handleRandomTweetOnClick}
        />
      );
    });
  };

  useEffect(() => {
    setUserProfileDataToState();
  }, []);

  return (
    <main
      id="random-tweet-page"
      className="flex center-y column"
    >
      {displayUsers()}

      <Modal size="lg" show={showModal} onHide={handleClose}>
        <Modal.Header closeButton>
          test
        </Modal.Header>

        <Modal.Body className="flex center-x">
          <Tweet
            tweetData={randomTweet}
            checkForMedia={props.checkForMedia}
            getMedia={props.getMedia}
          />
        </Modal.Body>

        <Modal.Footer>
          <Button variant="secondary" onClick={handleClose}>
            Close
          </Button>
        </Modal.Footer>

      </Modal>
    </main>
  );
}

export default RandomTweetPage;
