var express = require('express');
var router = express.Router();
var crypto = require('crypto');

/* It's very easy to deploy app using Heroku and Mlab. The tutorial walks through how to use express.js, node.js and set up and deploy
heroku CLI.    */

router.post('/messages', function(req, res, next) {
  var hash = crypto.createHash('sha256').update(req.body.message).digest('hex');
  // Save the hash and word in the database as key value pairs
  res.json(hash);
});

router.get('/messages', function(req, res, next) {
  // this will just query the mongo db using hash as key and return the value or 404 if it does not exist in our db
  res.json(req.path);
});

module.exports = router;
