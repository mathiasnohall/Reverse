var gulp = require('gulp');
var bower = require('gulp-bower');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var sass = require('gulp-sass');
var minifycss = require('gulp-clean-css');
var del = require('del');
var runSequence = require('run-sequence');
var sourcemaps = require('gulp-sourcemaps');
var livereload = require('gulp-livereload');

var paths = {
    js: [        
        'bower_components/jquery/dist/jquery.js', // JQuery
        'bower_components/bootstrap-sass/assets/javascripts/bootstrap.js', // Bootstrap js
        'bower_components/angular/angular.js', // angular
        'bower_components/angular-resource/angular-resource.js',// angular module to do http get and post
        'Scripts/angular/angularInit.js',
        'Scripts/angular/Config/local.js',
        'Scripts/angular/Services/*Service.js',
        'Scripts/angular/Controllers/*Controller.js'
    ],
    sass: [
        'Static/Styles/global.scss'
    ]
};

gulp.task('bower', function () {
    return bower();
});

gulp.task('clean', function () {
    return del('dist/**/*');
});

gulp.task('js', function () {
    return gulp.src(paths.js)
        .pipe(sourcemaps.init())
        .pipe(uglify())
        .pipe(concat('bundle.min.js'))
        .pipe(sourcemaps.write('./'))
        .pipe(gulp.dest('dist'));
});

gulp.task('style', function () {
    return gulp.src(paths.sass)
        .pipe(sourcemaps.init())
        .pipe(sass().on('error', sass.logError))
        .pipe(minifycss())
        .pipe(concat('bundle.min.css'))
        .pipe(gulp.dest('dist'))
        .pipe(sourcemaps.write('./'))
        .pipe(livereload());
});

// Rerun the task when a file changes 
gulp.task('watch', function () {
    livereload.listen();
    gulp.watch(paths.js, ['js']);
    gulp.watch('Static/Styles/**/*.scss', ['style']);
});


gulp.task('default', function () {
    runSequence('bower', 'clean', ['watch', 'js', 'style']);
});
