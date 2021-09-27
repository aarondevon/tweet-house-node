let express = require('express');
let app = express();
const PORT = process.env.PORT || 5000;

app.get('/api', (request, response) => {
  response.json({message: "Hello from the server!"})
});

// Start the server
app.listen(PORT, (error) => {
  if (error) return console.log(`Error: ${error}`);

  console.log(`Server listening on port ${PORT}`);
});
