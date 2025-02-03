CREATE TABLE user_account (
	id UUID PRIMARY KEY,
	username TEXT NOT NULL

);

CREATE TABLE book (
	id UUID PRIMARY KEY,
	title TEXT NOT NULL
);

CREATE TABLE author (
	id UUID PRIMARY KEY,
	name TEXT NOT NULL,
	book_id UUID REFERENCES book(id)
);

CREATE TABLE book_club (
	id UUID PRIMARY KEY,
	title TEXT NOT NULL
);

CREATE TABLE chapter (
	id UUID PRIMARY KEY,
	title TEXT,
	chapter_index INTEGER NOT NULL
);
