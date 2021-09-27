const axios = require('axios');

const keyword = 'tesla';

axios.get(
  `https://api.twitter.com/1.1/search/tweets.json?q=${keyword}&result_type=popular&tweet_mode=extended&count=15`
);
