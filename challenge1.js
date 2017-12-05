var express = require('express');
var router = express.Router();
var crypto = require('crypto');

/* GET home page. */
router.get('/', function(req, res, next) {
  res.render('index', { title: 'Express' });
});

router.post('/messages', function(req, res, next) {
  var hash = crypto.createHash('sha256').update(req.body.message).digest('hex');
  console.log(hash);
  res.json(hash);
});

router.get('/messages', function(req, res, next) {
  //var hash = crypto.createHash('sha256').update(req.body.message).digest('hex');
  console.log(req.path);
  //res.json(hash);
});

module.exports = router;
