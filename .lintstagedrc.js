
module.exports = {
    '*.cs': filenames => [
      `dotnet format --folder --include ${filenames.join(',')}`,
      `git add ${filenames.join(' ')}`,
    ],
};
